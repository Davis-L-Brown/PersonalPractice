using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataVisualization.Interfaces;

namespace DataVisualization.Clients
{
    public class CCity : ICity
    {

        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double population = 0;
        public double Population
        {
            get { return population; }
            set { population = value; } 
        }

        private DateTime foundingDate;
        public DateTime FoundingDate
        {
            get { return foundingDate; }
            set { foundingDate = value; }
        }
        
        public CCity(string name, double population, DateTime foundingDate)
        {
            Name = name;
            Population = population;
            FoundingDate = foundingDate;   
        }
    }
}
