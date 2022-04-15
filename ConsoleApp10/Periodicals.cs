using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Periodicals : PrintedEdition
    {
        public Periodicals(string productiontechnique, string productiontime, string material, string priceneed) : base(productiontechnique, productiontime, material)
        {
            PriceNeed = priceneed;//Цено потребность
        }

        public string PriceNeed { get; set; }

        public override string ToString()
        {
            return $"Тип - Периодические издания\n" +
                        $"техника производства  - {ProductionTime}\n" +
                        $"Цено потребность - {PriceNeed} \n" +
                        $"краски - {ProductioTechnique} \n" +
                        $"бумага - {Material} \n";
        }
    }
}
