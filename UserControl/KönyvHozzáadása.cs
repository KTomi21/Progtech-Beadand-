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
using NLog;

namespace Konyvtar_Rendszer_Kezeles
{
    public partial class konyHozzaadasaAblak : UserControl
    {
        private KonyvHozzaadasService konyvHozzaadasService;
        KonyvtarRendszer konyvtarRendszer = new KonyvtarRendszer();
        private FelhasznaloInterface felhasznaloInterface;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        
        public konyHozzaadasaAblak()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd";
            this.konyvtarRendszer = new KonyvtarRendszer();
            this.felhasznaloInterface = new FelhasznaloInterface();
            konyvtarRendszer.HozzaadObserver(felhasznaloInterface);
            this.konyvHozzaadasService =  new KonyvHozzaadasService(konyvtarRendszer);
        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            try
            {
                string konyvCime = textBox1.Text;
                string szerzo = textBox2.Text;
                string kiadasDatuma = dateTimePicker1.Text;
                string statusz = comboBox1.Text;

                Logger.Info($"Új könyv hozzáadása: {konyvCime}, szerző: {szerzo}, kiadás dátuma: {kiadasDatuma}, státusz: {statusz}");

                var letezoKonyv = konyvtarRendszer.GetKonyvek()
                .FirstOrDefault(k => k.KonyvCime == konyvCime);

                if (letezoKonyv != null)
                {
                    Logger.Warn($"Már létezik ilyen könyv: {konyvCime}");
                    MessageBox.Show("Már létezik ilyen könyv: " + konyvCime);
                    return;
                }

                Builder builder = new Builder()
                            .Cim(textBox1.Text)
                            .Szerzo(textBox2.Text)
                            .KiadasDatuma(dateTimePicker1.Text)
                            .Statusz(comboBox1.Text);

                KonyvTulajdonsagok konyv = builder.Build();
                konyvHozzaadasService.AddKonyv(konyv);

                for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(0, row) == null)
                    {
                        int id = row;
                        KonyvekHozzaadasa konyvek = new KonyvekHozzaadasa(id, konyvCime, szerzo, kiadasDatuma, statusz);

                        Label idLabel = new Label();
                        idLabel.Text = konyvek.ID.ToString();
                        idLabel.TextAlign = ContentAlignment.MiddleCenter;
                        idLabel.Dock = DockStyle.Fill;

                        Label konyvCimeLabel = new Label();
                        konyvCimeLabel.Text = konyvek.KonyvCime;
                        konyvCimeLabel.TextAlign = ContentAlignment.MiddleCenter;
                        konyvCimeLabel.Dock = DockStyle.Fill;

                        Label szerzoLabel = new Label();
                        szerzoLabel.Text = konyvek.Szerzo;
                        szerzoLabel.TextAlign = ContentAlignment.MiddleCenter;
                        szerzoLabel.Dock = DockStyle.Fill;

                        Label kiadasDatumaLabel = new Label();
                        kiadasDatumaLabel.Text = konyvek.KiadasDatuma;
                        kiadasDatumaLabel.TextAlign = ContentAlignment.MiddleCenter;
                        kiadasDatumaLabel.Dock = DockStyle.Fill;

                        Label statuszLabel = new Label();
                        statuszLabel.Text = konyvek.Statusz;
                        statuszLabel.TextAlign = ContentAlignment.MiddleCenter;
                        statuszLabel.Dock = DockStyle.Fill;

                        CheckBox checkBox = new CheckBox();
                        checkBox.TextAlign = ContentAlignment.MiddleCenter;
                        checkBox.Dock = DockStyle.Fill;

                        tableLayoutPanel1.Controls.Add(idLabel, 0, row);
                        tableLayoutPanel1.Controls.Add(konyvCimeLabel, 1, row);
                        tableLayoutPanel1.Controls.Add(szerzoLabel, 2, row);
                        tableLayoutPanel1.Controls.Add(kiadasDatumaLabel, 3, row);
                        tableLayoutPanel1.Controls.Add(statuszLabel, 4, row);
                        tableLayoutPanel1.Controls.Add(checkBox, 5, row);

                        konyvtarRendszer.ValtozasKonyvStatusz(statusz);

                        if (statusz == "Elérhető")
                        {
                            Logger.Info($"Könyv elérhető a rendszerben: {konyvCime}");
                        }
                        else
                        {
                            Logger.Info($"Könyv nem elérhető a rendszerben: {konyvCime}");
                        }

                        textBox1.Clear();
                        textBox2.Clear();
                        comboBox1.ResetText();
                        dateTimePicker1.Value = DateTime.Now;

                        return;
                    }
                }
                Logger.Warn("Nincs több üres sor a táblázatban.");
                MessageBox.Show("Nincs több üres sor a táblázatban.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Hiba történt a könyv hozzáadása során.");
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
