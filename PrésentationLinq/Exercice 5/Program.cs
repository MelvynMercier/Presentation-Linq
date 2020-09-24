using Exercice_5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_5
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

            var article = listArticle.FirstOrDefault(a => a.Nom == name);

            if(article != null)
            {
                Console.WriteLine($"Nom: {article.Nom}, Prix: {article.Prix}, Quantité: {article.Qte}");
            }
            else
            {
                Console.WriteLine("Article non trouvé");
            }
        }
    }
}
