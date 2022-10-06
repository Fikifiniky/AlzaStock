using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlzaStockCheck
{
    class Product
    {

        public int Id { get; set; } //id potom az bude porovnavani ceny oproti msrp aby se vedelo k cemu presne
        public string Name { get; set; }
        public string Price { get; set; }
        public string Availability { get; set; }
        public string Url { get; set; } //pro to, ze kdyz se klikne na produkt, tak se automaticky otevre stranka produktu
        public string Manufacturer { get; set; }
    }
}
