using System;
using HtmlAgilityPack;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtractHref("https://www.dr.dk/");

        }

        static void ExtractHref(string URL)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = web.Load(URL);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                HtmlAttribute att = link.Attributes["href"];
                if (att.Value.Contains("a"))
                {
                    Console.WriteLine(att.Value);
                }
            }
        }
    }
}