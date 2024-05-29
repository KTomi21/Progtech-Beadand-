using Konyvtar_Rendszer_Kezeles.Builder_Minta;
using Konyvtar_Rendszer_Kezeles.Class;
using Konyvtar_Rendszer_Kezeles.Observer;
using Konyvtar_Rendszer_Kezeles.OCP;
using Konyvtar_Rendszer_Kezeles.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konyvtar_Rendszer_Kezeles
{
    public partial class iranyitopultAblak : UserControl
    {
        private KonyvtarRendszer konyvtarRendszer;

        private IKeresesiStrategia keresesiStrategia;

        public iranyitopultAblak()
        {
            InitializeComponent();
            buttonKereses.Click += new EventHandler(buttonKereses_Click);
            konyvtarRendszer = new KonyvtarRendszer();
        }

        public iranyitopultAblak(KonyvtarRendszer konyvtarRendszer)
        {
            InitializeComponent();
            this.konyvtarRendszer = konyvtarRendszer;
        }

        private void buttonKereses_Click(object sender, EventArgs e)
        {
            List<IKonyv> _konyvek = testClass.GetIKonyvek();
            if (_konyvek == null || !_konyvek.Any())
            {
                MessageBox.Show("Nincsenek elérhető könyvek a kereséshez.");

                return;
            }

            listBoxEredmenyek.Items.Clear();
            string keresesiKriterium = textBoxKeresesiKriterium.Text;
            string keresesiTipus = comboBoxKeresesiTipus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(keresesiTipus))
            {
                MessageBox.Show("Válassz egy keresési típust!");
                return;
            }

            if (string.IsNullOrEmpty(keresesiKriterium))
            {
                MessageBox.Show("Írd be a keresési kritériumot!");
                return;
            }

            try
            {
                IKeresesiStrategia strategia = KeresesiStrategiaFactory.GetStrategia(keresesiTipus);
                List<IKonyv> eredmenyek = strategia.Kereses(testClass.GetIKonyvek(), keresesiKriterium);

                if (!eredmenyek.Any())
                {
                    MessageBox.Show("Nincs találat a keresési feltételeknek megfelelően.");
                }

                foreach (var konyv in eredmenyek)
                {
                    listBoxEredmenyek.Items.Add($"{konyv.Cim}");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a keresés során: " + ex.Message);
            }
        }
    }
}

