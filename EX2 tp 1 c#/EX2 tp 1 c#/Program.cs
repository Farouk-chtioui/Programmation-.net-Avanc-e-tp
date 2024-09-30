using System;

namespace EX2_tp_1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe(
                matricule: "10941",
                nom: "salim",
                prenom: "omar",
                dateNaissance: new DateTime(1990, 8, 4),
                dateEmbauche: new DateTime(2012, 11, 5),
                salaire: 10000
            );

            employe.AfficherEmploye();

            employe.AgumenterSalaire();

            Console.WriteLine("\nAprès augmentation du salaire :");
            employe.AfficherEmploye();
        }
    }
}