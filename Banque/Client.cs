using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Client
    {

        private string nom = "";    
        private string prenom = "";
        private static int lastNumero = 0;
        private readonly string numero;
        private readonly List<Compte> comptes = new();

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Numero { get => numero; }
        public List<Compte> Comptes { get => comptes;}

        public Client()
        {
            numero = (++lastNumero).ToString();
        }
        public Client(string _nom, string _prenom) : this() 
        {
            nom = _nom;
            prenom = _prenom;
        }

        public override string ToString()
        {
            return "Client N°" + numero + " : " + nom + " " + prenom;
        }

        public void AddCompte(Compte compte)
        {
            if (!comptes.Contains(compte))
            {
                comptes.Add(compte);
            }
            if (compte.Titulaire != this)
            {
                compte.Titulaire = this;
            }
        }

        public void RemoveCompte(string numero)
        {
            Compte? compte = comptes.Find(item => item.Numero == numero);
            if (compte != null)
            {
                comptes.Remove(compte);
                if (compte.Titulaire == this)
                {
                    compte.Titulaire = null;
                }
            }

        }


    }
}
