using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class CompteEpargne : Compte
    {
        private double txInterets = 0;
        private EpargneType type;

        public double TxInterets { get => txInterets;}
        internal EpargneType Type { get => type;}

        public CompteEpargne() : base()
        {
            Initialize();
        }

        public CompteEpargne(Client _titulaire, double _solde, EpargneType _type, string _devise = "€") : base(_titulaire, _solde, _devise)
        {
            Initialize();
        }

        private void Initialize()
        {
            numero = type.ToString() + "_" + numero;
            switch (type)
            {
                case EpargneType.Livret: txInterets = 2; break;
                case EpargneType.LDD: txInterets = 1.5; break;
                case EpargneType.CEL: txInterets = 1.2; break;
            }
        }


    }

    enum EpargneType
    {
        Livret = 0, LDD, CEL
    }
}
