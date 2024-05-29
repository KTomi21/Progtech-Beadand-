using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Konyvtar_Rendszer_Kezeles
{
    public partial class Főablak : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public Főablak()
        {
            InitializeComponent();
            Logger.Info("Főablak megnyitva.");
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            Logger.Info("A program leállt.");
            Application.Exit();
        }

        private void kijelentkezes_Click(object sender, EventArgs e)
        {
            DialogResult biztos = MessageBox.Show("Biztos ki akar jelentkezni?", "Biztonsági kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (biztos == DialogResult.Yes)
            {
                Logger.Info("A felhasználó kijelentkezett.");
                Bejelentkezés bejelentkezés = new Bejelentkezés();
                bejelentkezés.Show();
                this.Hide();
            }
        }

        private void iranyitopult_Click(object sender, EventArgs e)
        {
            iranyitopultAblak1.Visible = true;
            konyHozzaadasaAblak1.Visible = false;
            kiadottKonyvAblak1.Visible = false;
            visszaHozottKönyvek1.Visible = false;
        }

        private void konyvHozzaadasa_Click(object sender, EventArgs e)
        {
            iranyitopultAblak1.Visible = false;
            konyHozzaadasaAblak1.Visible = true;
            kiadottKonyvAblak1.Visible = false;
            visszaHozottKönyvek1.Visible = false;
        }

        private void kiadottKonyv_Click(object sender, EventArgs e)
        {
            iranyitopultAblak1.Visible = false;
            konyHozzaadasaAblak1.Visible = false;
            kiadottKonyvAblak1.Visible = true;
            visszaHozottKönyvek1.Visible = false;
        }

        private void visszahozottKonyv_Click(object sender, EventArgs e)
        {
            iranyitopultAblak1.Visible = false;
            konyHozzaadasaAblak1.Visible = false;
            kiadottKonyvAblak1.Visible = false;
            visszaHozottKönyvek1.Visible = true;
        }
    }
}
