namespace Banque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client cl1 = new Client();
            Compte cpte1 = new Compte();
            cpte1.Titulaire = cl1;
            cl1.Comptes.Add(cpte1);

        }
    }
}