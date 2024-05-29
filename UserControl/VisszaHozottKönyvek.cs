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
    public partial class visszahozottKonyvAblak : UserControl
    {
        private KonyvVisszaveteleService konyvVisszaveteleService;
        KonyvtarRendszer konyvtarRendszer = new KonyvtarRendszer();
        private FelhasznaloInterface felhasznaloInterface;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public visszahozottKonyvAblak()
        {
            InitializeComponent();
            this.konyvtarRendszer = new KonyvtarRendszer();
            this.felhasznaloInterface = new FelhasznaloInterface();
            konyvtarRendszer.HozzaadObserver(felhasznaloInterface);
            this.konyvVisszaveteleService = new KonyvVisszaveteleService(konyvtarRendszer);
        }

        private void visszavesz_Click(object sender, EventArgs e)
        {
            try
            {
                string nev = textBox22.Text;
                string konyvCime = textBox25.Text;
                string szerzo = textBox26.Text;
                string statusz = comboBox21.Text;

                Logger.Info($"Könyv visszavétele: {konyvCime}, szerző: {szerzo}, státusz: {statusz}");

                if (string.IsNullOrWhiteSpace(nev) || string.IsNullOrWhiteSpace(konyvCime) || string.IsNullOrWhiteSpace(szerzo) || string.IsNullOrWhiteSpace(statusz))
                {
                    Logger.Warn("Nincs kitöltve minden mező!");
                    MessageBox.Show("Minden mezőt töltsön ki!");
                    return;
                }

                if (!int.TryParse(textBox21.Text, out int id))
                {
                    Logger.Warn("Hibás formátum az ID mezőben!");
                    MessageBox.Show("Az ID mezőben számot adjon meg!");
                    return;
                }

                Builder builder = new Builder()
                           .ID(int.TryParse(textBox21.Text, out id) ? id : 0)
                           .Nev(textBox22.Text)
                           .Cim(textBox25.Text)
                           .Szerzo(textBox26.Text)
                           .Statusz(comboBox21.Text);

                KonyvTulajdonsagok konyv = builder.Build();
                konyvVisszaveteleService.ReturnKonyv(konyv);

                for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(0, row) == null)
                    {
                        VisszahozottKonyvek konyvek = new VisszahozottKonyvek(id, nev, konyvCime, szerzo, statusz);

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

                        Label szerzoLabel = new Label();
                        szerzoLabel.Text = konyvek.Szerzo;
                        szerzoLabel.TextAlign = ContentAlignment.MiddleCenter;
                        szerzoLabel.Dock = DockStyle.Fill;

                        Label statuszLabel = new Label();
                        statuszLabel.Text = konyvek.Statusz;
                        statuszLabel.TextAlign = ContentAlignment.MiddleCenter;
                        statuszLabel.Dock = DockStyle.Fill;

                        CheckBox checkBox = new CheckBox();
                        checkBox.TextAlign = ContentAlignment.MiddleCenter;
                        checkBox.Dock = DockStyle.Fill;

                        tableLayoutPanel1.Controls.Add(idLabel, 0, row);
                        tableLayoutPanel1.Controls.Add(nevLabel, 1, row);
                        tableLayoutPanel1.Controls.Add(konyvCimeLabel, 2, row);
                        tableLayoutPanel1.Controls.Add(szerzoLabel, 3, row);
                        tableLayoutPanel1.Controls.Add(statuszLabel, 4, row);
                        tableLayoutPanel1.Controls.Add(checkBox, 5, row);
                        
                        konyvtarRendszer.ValtozasKonyvStatusz(statusz);

                        if (statusz == "Visszahozott")
                        {
                            Logger.Info($"Könyv visszahozva: {konyvCime}");
                        }
                        else
                        {
                            Logger.Info($"Könyv nincs visszahozva: {konyvCime}");
                        }

                        textBox21.Clear();
                        textBox22.Clear();
                        textBox25.Clear();
                        textBox26.Clear();
                        comboBox21.ResetText();

                        return;
                    }
                }
                Logger.Warn("Nincs több üres sor a táblázatban.");
                MessageBox.Show("Nincs több üres sor a táblázatban.");
            }
            catch (FormatException)
            {
                Logger.Error("Hibás adatbevitel!");
                MessageBox.Show("Hibás adatbevitel. Ellenőrizze a mezők tartalmát.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Hiba történt a könyv visszavétele során.");
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
                        int id = -1;
                        for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                        {
                            Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                            if (control is Label label && col == 0)
                            {
                                int.TryParse(label.Text, out id);
                            }

                            if (control != null)
                            {
                                tableLayoutPanel1.Controls.Remove(control);
                                control.Dispose();
                            }
                        }

                        if (id != -1)
                        {
                            Logger.Info("Könyv törölve a táblázatból.");
                            konyvtarRendszer.RemoveKonyv(id);
                            konyvtarRendszer.RemoveVisszahozottKonyv(id);
                        }

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
