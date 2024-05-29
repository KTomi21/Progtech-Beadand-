using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using NLog;

namespace Konyvtar_Rendszer_Kezeles
{
    public partial class Bejelentkezés : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public Bejelentkezés()
        {
            InitializeComponent();
            Logger.Info("Bejelentkezés megnyitva.");
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            Logger.Info("A program leállt.");
            Application.Exit();
        }

        private void belepes_Click(object sender, EventArgs e)
        {
            string felhasznalonev = this.felhasznalonevTextBox.Text;
            string jelszo = this.jelszoTextBox.Text;

            if (string.IsNullOrWhiteSpace(felhasznalonev) || string.IsNullOrWhiteSpace(jelszo))
            {
                Logger.Warn("Helytelen felhasználónév vagy jelszó!");
                MessageBox.Show("Sikertelen bejelentkezés!");
            }
            else
            {
                Logger.Info("Siekres bejelentkezés: " + felhasznalonev);
                MessageBox.Show("Sikeres bejelentkezés!");
                Főablak foablak = new Főablak();
                foablak.Show();
                this.Hide();
            }
        }

        private void megjelenites_CheckedChanged(object sender, EventArgs e)
        {
            jelszoTextBox.PasswordChar = megjelenites.Checked ? '\0' : '*';
        }
    }
}
