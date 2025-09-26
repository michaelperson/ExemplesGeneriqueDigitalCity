using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerqueDemo.Models
{
    internal class Animal  :IViewable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string getView()
        {
            return $"Nom:{Name} - Description : {Description}";
        }

        public override string ToString()
        {
            return $"Nom:{Name} - Description : {Description}";
        }

        public Animal(string nom)
        {
            Name= nom ;
        }
    }
}
