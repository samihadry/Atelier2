using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class Compte
    {
        private readonly int NumCpt;
        private static int Cpt = 180186;
        protected readonly Client Titulaire;
        protected MAD Solde;
        private static MAD plafond = new MAD(2000);
        public List<Operation> ListeOperations;


        /*un constructeur static ,pas niveau de visblite(prive,pub) , pas d'argument , sans this
        il sert a initialiser les attributs statics
        Exemple:
        static Compte()
        {
            //Cpt = 180186;
            //plafond = new MAD(2000);
        }*/
        public Compte(Client cl)
        {
            this.Titulaire = cl;
            this.Solde = new MAD(0.00);
            this.ListeOperations = new List<Operation>();
            this.NumCpt = ++Cpt;
            cl.ListeComptes.Add(this);
        }
        public Compte(Client cl, MAD md)//Cons avec param
        {
            this.Titulaire = cl;
            this.Solde = md;
            this.ListeOperations = new List<Operation>();
            this.NumCpt = ++Cpt;
            cl.ListeComptes.Add(this);
        }

        public virtual bool Crediter(MAD Somme)
        {
            MAD ValNull = new MAD(0);
            string operation = "Credit";
            if (Somme > ValNull)
            {
                this.Solde += Somme;
                ListeOperations.Add(new Operation(operation, Somme, false));
                return true;
            }
            Console.WriteLine("impossible somme negatif !!!");
            return false;
        }
        public virtual bool Debiter(MAD Somme)
        {
            MAD ValNull = new MAD(0);
            string operation = "Debit";
            if (Somme > ValNull)
            {
                if (Solde>=Somme && plafond>=Somme)
                {
                    this.Solde -= Somme;
                    ListeOperations.Add(new Operation(operation, Somme, true));
                    return true;
                }
                else if (Somme > plafond)
                {
                    Console.WriteLine("Valeur superieur au plafond");
                    return false;
                }
                else
                {
                    Console.WriteLine("Impossible solde insuffisant");
                    return false;
                }
            }
            Console.WriteLine("impossible somme negatif !!");
            return false;
        }
        public bool Verser(Compte Cmpt, MAD Somme)
        {
            if (this.Debiter(Somme) == true)
            {
                Cmpt.Crediter(Somme);
                return true;
            }
            return false;
        }
        public void Consulter()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Numéro du Compte: " + this.NumCpt);
            Console.Write("Solde du compte: "); this.Solde.Afficher();
            Console.WriteLine("Propriétaire du compte : "); this.Titulaire.Afficher();
            Console.WriteLine("*********************************************");
        }
        public void AfficherOperation()
        {
            if (ListeOperations.Count > 0)
            {
                Console.WriteLine("\nListe des operations");
                foreach (Operation operation in ListeOperations)
                {
                    operation.Afficher();
                }
                return;
            } 
            Console.WriteLine("\nAucune Opération à afficher !!");
        }
    }
}
