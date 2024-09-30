using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_tp_1_c_
{
    internal class Employe
    {
        private string Matricule;
        private string Nom;
        private string Prenom;
        private DateTime DateNaissance;
        private DateTime DateEmbauche;
        private double Salaire;

        public string Matricule1 { get => Matricule; set => Matricule = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public DateTime DateNaissance1 { get => DateNaissance; set => DateNaissance = value; }
        public DateTime DateEmbauche1 { get => DateEmbauche; set => DateEmbauche = value; }
        public double Salaire1 { get => Salaire; set => Salaire = value; }

        public Employe(string matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, double salaire)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            DateEmbauche = dateEmbauche;
            Salaire = salaire;
            
        }
        public int Age()
        {
            return DateTime.Now.Year - DateNaissance.Year;
        }
        public int Anciennete()
        {
            return DateTime.Now.Year - DateEmbauche.Year;
        }
        public void AgumenterSalaire()
        {
            
            if(Anciennete() < 5)
            {
                Salaire += Salaire * 2 / 100;
            }
            else if (Anciennete() < 10)
            {
                Salaire += Salaire * 5 / 100;
            }
            else
            {
                Salaire += Salaire * 10 / 100;
            }   
        }
        public void AfficherEmploye()
        {
            Console.WriteLine($"Matricule : {Matricule}");
            Console.WriteLine($"Nom complet : {Nom.ToUpper()} {char.ToUpper(Prenom[0]) + Prenom.Substring(1).ToLower()}");
            Console.WriteLine($"Age : {Age()}");
            Console.WriteLine($"Ancienneté : {Anciennete()}");
            Console.WriteLine($"Salaire : {Salaire}");
        }
    }
}
