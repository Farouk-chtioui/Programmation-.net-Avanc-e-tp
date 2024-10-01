using System;

namespace EX3_tp1_c_
{
    class Program
    {
        static void Main()
        {
            Console.Write("Donner le taux de TVA pour tous les articles : ");
            Article.TauxTva = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Le taux TVA est : " + Article.TauxTva + "%");

            int articleCount = 1;
            while (true)
            {
                Console.WriteLine($"Article {articleCount}:");

                Console.Write("Donner la référence: ");
                string refernce = Console.ReadLine();

                Console.Write("Donner la désignation: ");
                string designation = Console.ReadLine();

                Console.Write("Donner le prix HT: ");
                double prixHt = Convert.ToDouble(Console.ReadLine());

                var article = new Article(refernce, designation, prixHt);
                article.Afficher();

                Console.Write("Voulez-vous ajouter un autre article? (o/n): ");
                if (Console.ReadLine().ToLower() != "o")
                {
                    break;
                }

                articleCount++;
            }
        }
    }
}