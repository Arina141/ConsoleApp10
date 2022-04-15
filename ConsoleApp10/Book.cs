using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Book : PrintedEdition
    {
        public Book(string productiontechnique, string productiontime, string material, string finalprocess) : base(productiontechnique, productiontime, material)
        {
            FinalProcess = finalprocess;//Заключительный процесс
        }

        public string FinalProcess { get; set; }

        public override string ToString()
        {
            return $"Тип - Книга\n" +
                         $"техника производства  - {ProductionTime}\n" +
                         $"конечный процесс - {FinalProcess} \n" +
                         $"краски - {ProductioTechnique} \n" +
                         $"бумага - {Material} \n";
        }
    }
}
