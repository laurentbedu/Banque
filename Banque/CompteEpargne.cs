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
        public EpargneType Type { get => type;}

        public CompteEpargne() : base()
        {
            Initialize();
        }

        public CompteEpargne(EpargneType _type) : base()
        {
            Initialize(_type);
        }

        public CompteEpargne(EpargneType _type, Client _titulaire, double _solde, string _devise = "€") : base(_titulaire, _solde, _devise)
        {
            Initialize(_type);
        }

        private void Initialize(EpargneType _type = EpargneType.Livret)
        {
            type = _type;
            numero = type.ToString() + "_" + numero;
            switch (type)
            {
                case EpargneType.Livret: txInterets = 2; break;
                case EpargneType.LDD: txInterets = 1.5; break;
                case EpargneType.CEL: txInterets = 1.2; break;
            }
        }

        public void AddInterests(ushort days)
        {
            double amount = Solde * txInterets / 36500 * days;
            Crediter(amount);
        }


    }

    enum EpargneType
    {
        Livret, LDD, CEL
    }
}
