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
            Client cl2 = new Client();
            Compte cpte1 = new Compte();
            Compte cpte2 = new Compte();
            cpte1.Titulaire = cl1;
            cl1.AddCompte(cpte2);
            cpte1.Titulaire = cl2;
            cl2.AddCompte(cpte2);
            cl2.RemoveCompte("1");
            cpte1.Titulaire = cl1;


        }
    }
}