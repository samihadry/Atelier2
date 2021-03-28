using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class MAD
    {
        private double Valeur;
        public MAD(double val)
        {
            this.Valeur = val;
        }
        public void Afficher()
        {
            Console.WriteLine(this.Valeur + " MAD");
        }
        public static MAD operator +(MAD v0, MAD v1)
        {
            MAD SOMME = new MAD(0);
            SOMME.Valeur = v0.Valeur + v1.Valeur;
            return SOMME;

        }
        public static MAD operator -(MAD v0, MAD v1)
        {
            MAD SOUSTRACTION = new MAD(0);
            SOUSTRACTION.Valeur = v0.Valeur - v1.Valeur;
            return SOUSTRACTION;
        }
        public static MAD operator *(MAD v0,double v1)
        {
            MAD RES = new MAD(0);
            RES.Valeur = v0.Valeur * v1;
            return RES;
        }
        public static bool operator >(MAD v0, MAD v1)
        {
            if (v0.Valeur > v1.Valeur)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        public static bool operator <(MAD v0, MAD v1)
        {
            if (v0.Valeur < v1.Valeur)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        public static bool operator >=(MAD v0, MAD v1)
        {
            if (v0.Valeur >= v1.Valeur)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator <=(MAD v0, MAD v1)
        {
            if (v0.Valeur <= v1.Valeur)
            {
                return true;
            }
            else
                return false;
        }
    }
}
