using HtmlAgilityPack;
using System.Net.Http;

namespace WebCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            startCrawlerasync();
        }

        private static async Task startCrawlerasync()
        {
            var url = "http://www.automobile.tn/neuf/bmw.3/";
            var httpClient = new HttpClient();
            var html =await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var divs =
                htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "").Equals("versions-item")).ToList();
        }
    }
}

