using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerqueDemo.Models
{
    internal class Personnage : IViewable
    {
        public Personnage()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public DateTime BirthDate { get; set; }

        public string getView()
        {
            return $"Id : {Id} - Name : {Name} - FirstName : {FirstName} - BirthDate: {BirthDate}";
        }

        public override string ToString()
        {
            return $"Id : {Id} - Name : {Name} - FirstName : {FirstName} - BirthDate: {BirthDate}";
        }
    }
}
