using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class PrintedEdition//Печатное издание
    {
        public PrintedEdition(string productiontechnique, string productiontime, string material)
        {
            ProductioTechnique = productiontechnique;//техника производства 
            ProductionTime = productiontime;//Производство время
            Material = material;//материал
        }
        public string ProductionTime { get; set; }
        public string Material { get; set; }

        public string ProductioTechnique { get; set; }

        public override string ToString()
        {
            return $"Тип - Печатное издание\n" +
                $"техника производства  - {ProductionTime}\n" +
                $"материал - {Material} \n" +
                $"краски - {ProductioTechnique} \n";
        }
    }
}
