using NLog;

namespace Konyvtar_Rendszer_Kezeles
{
    public partial class Kezd�lap : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public Kezd�lap()
        {
            InitializeComponent();
            Logger.Info("A program elindult.");
        }

        private void tovabb_Click(object sender, EventArgs e)
        {
            Logger.Info("A program tov�bb l�pett a rendszerbe.");

            Bejelentkez�s bejelentkezes = new Bejelentkez�s();
            bejelentkezes.Show();
            this.Hide();
        }
    }
}
