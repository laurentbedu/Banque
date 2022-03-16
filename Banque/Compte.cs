using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Compte
    {
        private Client titulaire;
        private double solde = 0;
        private string devise = "€";
        private static int lastNumero = 0;
        private readonly string numero;

        public Client Titulaire { 
            get => titulaire; 
            set {
                if (titulaire != value)
                {
                    titulaire.RemoveCompte(this.numero);
                    titulaire = value;
                    titulaire.AddCompte(this);
                }
            } 
        }
        public double Solde { get => solde; private set => solde = value; }
        public string Devise { get => devise; set => devise = value; }
        public string Numero { get => numero; }

        public Compte() {
            numero = (++lastNumero).ToString();
        }

        public Compte(Client _titulaire, double _solde, string _devise = "€") : this()
        {
            titulaire = _titulaire;
            solde = _solde;
            devise = _devise;
        }

        public void Crediter(double montant)
        {
            solde = solde + montant;
        }

        public void Debiter(double montant)
        {
            solde = solde - montant;
        }

        public override string ToString()
        {
            return "Compte N°" + numero + " en " + devise + "Solde : " + solde + "€";
        }

        
    }
}
