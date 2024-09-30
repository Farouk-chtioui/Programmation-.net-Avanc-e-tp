using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_c_
{

    internal class Client
    {
        private string cin;
        private string nom;
        private string prenom;
        private string tel;

        public Client(string cin, string nom, string prenom, string tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public Client(string cin, string prenom, string nom)
        {
            this.cin = cin;
            this.prenom = prenom;
            this.nom = nom;
        }

        public void Afficher()
        {
            Console.WriteLine("CIN:" + cin);
            Console.WriteLine("Nom:" + nom);
            Console.WriteLine("Prénom:" + prenom);
            if (tel != "")
            {
                Console.WriteLine("Téléphone:" + tel);

            }
        }

        public string GetCin()
        {
            return cin;
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetPrenom()
        {
            return prenom;
        }

        public string GetTel()
        {
            return tel;
        }

        public void SetCin(string cin)
        {
            this.cin = cin;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public void SetTel(string tel)
        {
            this.tel = tel;
        }
    }

}
