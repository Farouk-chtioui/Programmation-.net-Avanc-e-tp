using System;

namespace tp_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("EE1112", "Salim", "Omar", "0611111");
            Client client2 = new Client("EE333334", "Karimi", "Marie", "06222222222");

            Compte compte1 = new Compte(client1);
            Compte compte2 = new Compte(client2);

            
            Console.WriteLine("******************************* :");

            compte1.Crediter(100);
            compte2.Crediter(100);
            compte1.Debiter(50);
            compte1.Crediter(25, compte2);

            Console.WriteLine("\nC2 :");
         
            compte2.Afficher();

            Console.WriteLine("\n C1 :");

            compte1.Afficher();
            Compte.afficherNbCompte();
        }
    }
}