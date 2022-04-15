using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Newspaper : PrintedEdition
    {
        public Newspaper(string productiontechnique, string productiontime, string material, string paperr) : base(productiontechnique, productiontime, material)
        {
            Paperr = paperr;///бумага
        }

        public string Paperr { get; set; }

        public override string ToString()
        {
            return $"Тип - Газета\n" +
                $"техника производства  - {ProductionTime}\n" +
                $"материал - {Paperr} \n" +
                $"краски - {ProductioTechnique} \n" +
                $"бумага - {Material} \n";
        }
    }
}
