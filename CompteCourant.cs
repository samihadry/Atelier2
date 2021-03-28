using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class CompteCourant : Compte
    {
        private MAD Decouvert;
        public CompteCourant(Client cl, MAD decouvert) : base(cl)
        {
            this.Decouvert = decouvert;
        }

        public override bool Debiter(MAD Somme)
        {
            string operation = "Debit";
            if (Somme > new MAD(0))
            {
                if (Solde>=(Somme + Decouvert))
                {
                    this.Solde -= Somme;
                    ListeOperations.Add(new Operation(operation, Somme, true));
                    return true;
                }
                else
                {
                    Console.WriteLine("Impossible  ");
                    return false;
                }
            }
            Console.WriteLine("Impossible somme negatif !!");
            return false;
        }
    }
}
