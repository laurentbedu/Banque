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
            Client client1 = new Client();
            Client client2 = new Client();
            Compte cpte1 = new Compte();
            Compte cpte2 = new Compte();
            cpte1.Titulaire = client1;

            //CompteEpargne livret = new CompteEpargne();

        }
    }
}