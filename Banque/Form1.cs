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
            //Client client1 = new Client();
            //Client client2 = new Client();
            //Compte cpte1 = new Compte();
            //Compte cpte2 = new Compte();
            //cpte1.Titulaire = client1;
            //cpte1.Titulaire = client1;
            //client1.AddCompte(cpte1);
            //client1.AddCompte(cpte2);
            //client2.AddCompte(cpte1);
            //cpte2.Titulaire = client2;
            //client2.RemoveCompte(cpte2);
            //client2.RemoveCompte(cpte2);

            //CompteCourant compteCourant = new CompteCourant();
            //compteCourant.DecouvertMax = 100;
            //compteCourant.Debiter(50);
            //compteCourant.Debiter(100);

            //CompteEpargne compteEpargne = new CompteEpargne();
            //compteEpargne.Debiter(50);

            Compte comptecourant2 = new CompteCourant();
            ((CompteCourant)comptecourant2).DecouvertMax = 100;
            comptecourant2.Debiter(50);

            //CompteEpargne livret = new CompteEpargne();
            //CompteEpargne ldd = new CompteEpargne(EpargneType.LDD);

        }
    }
}