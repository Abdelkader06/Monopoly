using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classe
{
    public class Station : Property
    {
        public Station(string name, int price,
            int position) : base(name, price, position, 150)

        {
            this.name = name;
            this.price = price;
            this.position = position;
            rentCost = 150;
        }

        public override string ToString()
        {
            return "[STATION]" + base.ToString();
        }
    }
}
