using Exercice_4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var listArticle = new List<Article>
            {
                new Article("Article 1", new DateTime(2016, 4, 21)),
                new Article("Article 2", new DateTime(2002, 11, 6)),
                new Article("Article 3", new DateTime(2408, 1, 30)),
                new Article("Article 4", new DateTime(2130, 7, 10))
            };

            var articles = (from article in listArticle
                          where article.Date <= new DateTime(2020, 9, 24)
                            select article).ToList();

            articles.ForEach(art =>
            {
                Console.WriteLine($"Nom : {art.Nom}, Date : {art.Date}");
            });
        }
    }
}
