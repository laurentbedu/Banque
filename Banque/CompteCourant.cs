using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class CompteCourant : Compte
    {
        private double decouvertMax = 0;

        public double DecouvertMax { get => decouvertMax; set => decouvertMax = value; }

        public override void Debiter(double montant)
        {
            if (Solde - montant >= -decouvertMax)
            {
                Solde = Solde - montant;
            }
        }
    }
}
