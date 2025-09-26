using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerqueDemo.Models
{
    internal class Meubles:IViewable
    {
        public string Marque { get; set; }
        public bool EstAntiquite { get;set; }
        public double Prix { get;set; }

        public string getView()
        {
            return $"Marque : {Marque} - Prix : {Prix} - Antiquite ? : {EstAntiquite}";
        }

        public override string ToString()
        {
            return $"Marque : {Marque} - Prix : {Prix} - Antiquite ? : {EstAntiquite}";
        }
    }
}
