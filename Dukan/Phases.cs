using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukan
{
    class Phases
    {
        private string name;
        private string[] categories;
        private string[,] descriptions;
        private string description;


        public Phases(string name, string[] categories, string[,] descriptions)
        {
            this.name = name;
            this.categories = categories;
            this.descriptions = descriptions;
        }

        public Phases (string name, string desciption)
        {
            this.name = name;
            this.description = desciption;
        }
    }
}
