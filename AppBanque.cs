using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class AppBanque
    {
            public void AppTest (){ 
            
            Client client1 = new Client("sami", "hadry", "casa1");//ajouter client 1
            
           
            Client client2 = new Client("khalid", "semlali", "casa2");//ajouter client 2

            

            MAD MAD1 = new MAD(5000);
            MAD MAD2 = new MAD(10000);
            Compte compte1 = new Compte(client1, MAD1);//création du compte 1
            Compte compte2 = new Compte(client2, MAD2);//création du compte 2
            Console.WriteLine("*****Affichage du client 1*****");
            client1.Afficher();
            Console.WriteLine("*****Affichage du client 2*****");
            client2.Afficher();
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 1 avant de débiter*****");
            compte1.Consulter();
            //-------------------------------débiter------------------------------------
            Console.Write("Donnez une valeur à débiter : "); double val = double.Parse(Console.ReadLine());
            MAD deb = new MAD(val);
            if (compte1.Debiter(deb))
            {
                Console.WriteLine("Compte 1 débiter avec succé!!");
            }
            else
                Console.WriteLine("Compte 1 n'est pas débiter!!");
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 1 après le débit*****");
            compte1.Consulter();
            //-------------------------------créditer------------------------------------
            Console.Write("Donnez une valeur à créditer : "); double val1 = double.Parse(Console.ReadLine());
            MAD cred = new MAD(val1);
            if (compte2.Crediter(cred))
            {
                Console.WriteLine("Compte 2 Créditer avec succé!!");

            }
            else
                Console.WriteLine("Compte 1 n'est pas créditer!!");
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 2 du client 2*****");
            compte2.Consulter();

            //-------------------------------verser------------------------------------
            Console.WriteLine("*****Versement*****");
            Console.Write("Donnez une somme à verser : "); double S = double.Parse(Console.ReadLine());
            MAD somme = new MAD(S);
            if (compte1.Verser(compte2, somme))
            {
                Console.WriteLine("Virement bien passé !!");
            }
            else
                Console.WriteLine("Virement échoué !!");

            //------------------------------------------------------
            Console.WriteLine("*****Consultation du compte 1 *****");
            compte1.Consulter();

            Console.WriteLine("*****Consultation du compte 2 *****");
            compte2.Consulter();
            //---------------Partie 2 test---------------------
            CompteEpargne compteepargne1 = new CompteEpargne(client1, 30);
            compteepargne1.Crediter(new MAD(100));
            compteepargne1.CalculInteret();
            compteepargne1.AfficherOperation();
            compteepargne1.Consulter();
            CompteEpargne compteepargne2 = new CompteEpargne(client2, 20);
            Operation op1 = new Operation("Dépot", new MAD(300), false);
            Operation op2 = new Operation("Retrait", new MAD(100), true);
            compteepargne2.Debiter(new MAD(200));
            Console.Write("Operation "); op1.Afficher();
            op2.Afficher();
            compteepargne2.AfficherOperation();
            compteepargne2.Consulter();
            client1.AfficherListeComptes();
            
            Console.ReadKey();
        }
    }
}
