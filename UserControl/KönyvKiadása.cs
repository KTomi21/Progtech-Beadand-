using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Konyvtar_Rendszer_Kezeles.Builder_Minta;
using Konyvtar_Rendszer_Kezeles.Class;
using Konyvtar_Rendszer_Kezeles.Observer;
using Konyvtar_Rendszer_Kezeles.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NLog;

namespace Konyvtar_Rendszer_Kezeles
{
    public partial class kiadottKonyvAblak : UserControl
    {
        private KonyvKiadasService konyvKiadasService;
        private KonyvtarRendszer konyvtarRendszer = new KonyvtarRendszer();
        private FelhasznaloInterface felhasznaloInterface;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public kiadottKonyvAblak()
        {
            InitializeComponent();
            dateTimePicker11.Format = DateTimePickerFormat.Custom;
            dateTimePicker11.CustomFormat = "yyyy.MM.dd";
            dateTimePicker12.Format = DateTimePickerFormat.Custom;
            dateTimePicker12.CustomFormat = "yyyy.MM.dd";
            this.konyvtarRendszer = new KonyvtarRendszer();
            this.felhasznaloInterface = new FelhasznaloInterface();
            konyvtarRendszer.HozzaadObserver(felhasznaloInterface);
            this.konyvKiadasService = new KonyvKiadasService(konyvtarRendszer);
        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            try
            {
                string nev = textBox12.Text;
                string konyvCime = textBox15.Text;
                string kiadasDatuma = dateTimePicker11.Text;
                string lejaratDatuma = dateTimePicker12.Text;

                Logger.Info($"Könyv kiadása {nev} számára, {konyvCime}, {kiadasDatuma}-tól, {lejaratDatuma}-ig");

                if (string.IsNullOrWhiteSpace(nev) || string.IsNullOrWhiteSpace(konyvCime))
                {
                    Logger.Warn("Nincs kitöltve minden mező!");
                    MessageBox.Show("Minden mezőt töltsön ki!");
                    return;
                }

                if (!int.TryParse(textBox11.Text, out int id))
                {
                    Logger.Warn("Hibás formátum az ID mezőben!");
                    MessageBox.Show("Az ID mezőben számot adjon meg!");
                    return;
                }

                Builder builder = new Builder()
                            .ID(int.TryParse(textBox11.Text, out id) ? id : 0)
                            .Nev(textBox12.Text)
                            .Cim(textBox15.Text)
                            .KiadasDatuma(dateTimePicker11.Text)
                            .LejaratDatuma(dateTimePicker12.Text);

                KonyvTulajdonsagok konyv = builder.Build();
                konyvKiadasService.IssueKonyv(konyv);

                for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(0, row) == null)
                    {
                        KonyvekKiadasa konyvek = new KonyvekKiadasa(id, nev, konyvCime, kiadasDatuma, lejaratDatuma);

                        Label idLabel = new Label();
                        idLabel.Text = konyvek.ID.ToString();
                        idLabel.TextAlign = ContentAlignment.MiddleCenter;
                        idLabel.Dock = DockStyle.Fill;

                        Label nevLabel = new Label();
                        nevLabel.Text = konyvek.Nev;
                        nevLabel.TextAlign = ContentAlignment.MiddleCenter;
                        nevLabel.Dock = DockStyle.Fill;

                        Label konyvCimeLabel = new Label();
                        konyvCimeLabel.Text = konyvek.KonyvCime;
                        konyvCimeLabel.TextAlign = ContentAlignment.MiddleCenter;
                        konyvCimeLabel.Dock = DockStyle.Fill;

                        Label kiadasDatumaLabel = new Label();
                        kiadasDatumaLabel.Text = konyvek.KiadasDatuma;
                        kiadasDatumaLabel.TextAlign = ContentAlignment.MiddleCenter;
                        kiadasDatumaLabel.Dock = DockStyle.Fill;

                        Label lejaratDatumaLabel = new Label();
                        lejaratDatumaLabel.Text = konyvek.KiadasDatuma;
                        lejaratDatumaLabel.TextAlign = ContentAlignment.MiddleCenter;
                        lejaratDatumaLabel.Dock = DockStyle.Fill;

                        CheckBox checkBox = new CheckBox();
                        checkBox.TextAlign = ContentAlignment.MiddleCenter;
                        checkBox.Dock = DockStyle.Fill;

                        tableLayoutPanel1.Controls.Add(idLabel, 0, row);
                        tableLayoutPanel1.Controls.Add(nevLabel, 1, row);
                        tableLayoutPanel1.Controls.Add(konyvCimeLabel, 2, row);
                        tableLayoutPanel1.Controls.Add(kiadasDatumaLabel, 3, row);
                        tableLayoutPanel1.Controls.Add(lejaratDatumaLabel, 4, row);
                        tableLayoutPanel1.Controls.Add(checkBox, 5, row);

                        Logger.Info($"Könyv kiadva: {konyvCime}");

                        textBox11.Clear();
                        textBox12.Clear();
                        textBox15.Clear();
                        dateTimePicker11.Value = DateTime.Now;
                        dateTimePicker12.Value = DateTime.Now;

                        return;
                    }
                }
                Logger.Warn("Nincs több üres sor a táblázatban.");
                MessageBox.Show("Nincs több üres sor a táblázatban.");

            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Hiba történt a könyv kiadása során.");
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            try
            {
                for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
                {
                    CheckBox checkBox = (CheckBox)tableLayoutPanel1.GetControlFromPosition(5, row);
                    if (checkBox != null && checkBox.Checked)
                    {
                        for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                        {
                            Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                            if (control != null)
                            {
                                tableLayoutPanel1.Controls.Remove(control);
                                control.Dispose();
                            }
                        }
                        konyvtarRendszer.RemoveKonyv(row);
                        Logger.Info("Könyv törölve a táblázatból.");

                        for (int nextRow = row + 1; nextRow < tableLayoutPanel1.RowCount; nextRow++)
                        {
                            for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                            {
                                Control control = tableLayoutPanel1.GetControlFromPosition(col, nextRow);
                                if (control != null)
                                {
                                    tableLayoutPanel1.Controls.Remove(control);
                                    tableLayoutPanel1.Controls.Add(control, col, nextRow - 1);
                                }
                            }
                        }
                        row--;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Hiba történt könyv törlése közben.");
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }
    }
}
