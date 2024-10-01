using System;

namespace EX3_tp1_c_
{
    internal class Article
    {
        private string refernce;
        private string designation;
        private double prixHt;
        private static decimal tauxTva;

        public string Refernce { get => refernce; set => refernce = value; }
        public string Designation { get => designation; set => designation = value; }
        public double PrixHt { get => prixHt; set => prixHt = value; }
        public static decimal TauxTva
        {
            get { return tauxTva; }
            set { tauxTva = value; }
        }

        public Article() { }
        public Article(string refernce, string designation, double prixHt)
        {
            this.refernce = refernce;
            this.designation = designation;
            this.prixHt = prixHt;
        }
        public Article(string refernce, string designation)
        {
            this.refernce = refernce;
            this.designation = designation;
        }
        public Article(Article existingArticle)
        {
            this.refernce = existingArticle.refernce;
            this.designation = existingArticle.designation;
            this.prixHt = existingArticle.prixHt;
        }
        public double CalculerPrixTTC()
        {
            return prixHt + (prixHt * (double)TauxTva / 100);
        }
        public void Afficher()
        {
            Console.WriteLine("Référence : " + refernce);
            Console.WriteLine("Désignation : " + designation);
            Console.WriteLine("Prix HT : " + prixHt);
            Console.WriteLine("Le prix TTC est " + CalculerPrixTTC());
        }
    }
}
