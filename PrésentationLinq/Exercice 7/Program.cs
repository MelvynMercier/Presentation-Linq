using Exercice_7.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_7
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

            Console.WriteLine($"Prix Minimum = {listArticle.Min(a => a.Prix)}");
            Console.WriteLine($"Prix Maximum = {listArticle.Max(a => a.Prix)}");
            Console.WriteLine($"Prix Moyen = {listArticle.Average(a => a.Prix)}");
        }
    }
}
