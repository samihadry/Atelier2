using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class Client
    {
        private string Nom;
        private string Prenom;
        private string Adresse;
        public List<Compte> ListeComptes;

        public Client(string N, string P, string A)
        {
            this.Nom = N;
            this.Prenom = P;
            this.Adresse = A;
            this.ListeComptes = new List<Compte>();


        }
        public void Afficher()
        {
            Console.WriteLine($"Client : Nom : {this.Nom} Prénom : {this.Prenom} Adresse : {this.Adresse}");
            /*
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Nom : " + this.Nom);
            Console.WriteLine("Prénom : " + this.Prenom);
            Console.WriteLine("Adresse : " + this.Adresse);
            Console.WriteLine("-----------------------------------");*/
        }
        public void AfficherListeComptes()
        {
            Console.WriteLine($"Liste des comptes du client : {this.Nom} {this.Prenom}");
            foreach (Compte Cpt in ListeComptes)
            {
                Cpt.Consulter();
                Cpt.AfficherOperation();
                Console.WriteLine();
            }
        }
    }
}
