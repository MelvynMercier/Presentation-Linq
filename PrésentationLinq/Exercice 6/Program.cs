using Exercice_6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var listArticle = new List<Article>
            {
                new Article("Article 1", 5, 10.99),
                new Article("Article 2", 10, 45.99),
                new Article("Article 3", 1, 15.99),
                new Article("Article 4", 6, 7.99)
            };

            Console.Write("Saisissez le nom de l'article à afficher : ");
            var name = Console.ReadLine();

            var tuple = SearchArticle(listArticle, name);

            Console.WriteLine($"Nom: {name}, Prix: {tuple.Item2}, Quantité: {tuple.Item1}");
        }

        public static Tuple<int, double> SearchArticle(List<Article> list, string name)
        {
            var article = list.FirstOrDefault(a => a.Nom == name);
            return new Tuple<int, double>(article.Qte, article.Prix);
        }
    }
}




