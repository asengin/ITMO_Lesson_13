using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Building
{
    class MultiBuilding : Building
    {
        private byte FloorsBuilding { get; set; }
        
        public MultiBuilding(string adress, double lenght, double width, double height, byte floors)
            : base(adress, lenght, width, height)
        {
            FloorsBuilding = floors;
        }

        public string Print()
        {
            return base.Print() + $"\nКол-во этажей: {FloorsBuilding}";
        }
    }
}
