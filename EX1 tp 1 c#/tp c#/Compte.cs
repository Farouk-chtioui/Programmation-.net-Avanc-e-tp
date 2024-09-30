using System;

namespace tp_c_
{
    internal class Compte
    {
        private double solde;
        private Client client;
        private int numero;
        private static int  nbcompte=1;

        public double Solde { get => solde; set => solde = value; }
        internal Client Client { get => client; set => client = value; }

        public Compte(Client client)
        {
            this.client = client;
            numero=nbcompte++;
        }
        public void Crediter(double montant )
        {
            solde += montant;
            Console.WriteLine("passed");
        }
        public void Crediter(double montant, Compte c)
        {
            if (montant <= c.solde)
            {
                c.solde -= montant;
                solde += montant;
                Console.WriteLine("the operation worked correctly ");
            }else{
                Console.WriteLine("not enough money");

            }
        }
        public void Debiter(double montant)
        {
            if (montant <= solde)
            {
                solde -= montant;
                Console.WriteLine("the operation worked correctly");
            }
            else
            {
                Console.WriteLine("didnt work");
            }
  
        }
        public void Debiter(double montant, Compte c)
        {
            if (montant <= solde)
            {
                c.solde += montant;
                solde -= montant;
                Console.WriteLine("worked");

            }
            else
            {
                Console.WriteLine("failed");
            }
        }
        public void Afficher()
        {
            Console.WriteLine($"Numéro de compte : {numero}");
            Console.WriteLine($"Solde : {solde}");
            Console.WriteLine($"Client : {client.Afficher}"); 
        }
        public static void afficherNbCompte()
        {
            Console.WriteLine($"Nombre de compte : {nbcompte}");
        }
    }
}
