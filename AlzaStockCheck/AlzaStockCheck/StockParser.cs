using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace AlzaStockCheck
{
    class StockParser
    {
        private static Form1 maiForm;
        public StockParser(Form1 form)
        {
            maiForm = form;
        }
        public List<Product> GetProducts(SKUs gpuType)
        {
            string htmlUrl = GpuUrls.urls.First(x => x.Key == gpuType).Value;

            //if (htmlUrl == String.Empty)
            //    return null; //jelikoz jeste vsechny typy RTX karet nemaji listing na alze... a nebo jeste lepe okomentovat je docasne v tom dictionary
            string html = DownloadRawHtml(htmlUrl);

            return ExtractProductInfoToList(html);

        }
        private List<Product> ExtractProductInfoToList(string html)
        {
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);

            var parentDiv = document.DocumentNode.SelectSingleNode("//*[@id=\"boxes\"]");

            var nodes = parentDiv.Elements("div");

            List<Product> returnList = new List<Product>();

            foreach (var node in nodes)
            {
                string name = String.Empty;


                //pak trošku upravit ty XPathy, po tom kurzu XML vidím jaká je tohle (funkční) prasárna, // shall not exist
                var nameNode = node.SelectSingleNode(".//div[@class='top']/div[@class='fb']/a");



                var priceNode = node.SelectSingleNode(".//div[@class='bottom']/div[@class='price']/div[@class='price__price-box-wrapper']/div[@class='price-box js-price-box price-box--Normal price-box--location-box']/div[@class='price-box__prices']/span");


                var availabilityNpde = node.SelectSingleNode(".//div[@class='bottom']/div[@class='avl extended']/span/div");

                var url = String.Format(@"https://www.alza.cz{0}", nameNode?.GetAttributeValue("href", ""));
                if (nameNode == null || priceNode == null || availabilityNpde == null)
                    continue;


                returnList.Add(new Product()
                {
                    Name = nameNode.InnerText,
                    Price = priceNode.InnerText == "Cena nebyla stanovena" ? "Neznámá cena" : new string(priceNode.InnerText.Where(c => char.IsDigit(c)).ToArray()),
                    Availability = availabilityNpde.InnerText.ToLower().Contains("skladem") ? "Skladem" : "Nedostupná",
                    Manufacturer = nameNode.InnerText.Split(' ')[0],
                    Url = url
                });
            }

            return returnList;
        }
        private string DownloadRawHtml(string url)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            return wc.DownloadString(url);
        }

        
    }
}
