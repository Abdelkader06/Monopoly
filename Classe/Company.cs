using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classe
{
    public class Company : Property
    {
        public Company(string name, int price,
            int position) : base(name, price, position, 100)
        {
            this.name = name;
            this.price = price;
            this.position = position;
            rentCost = 100;
        }

        public override string ToString()
        {
            return "[Company] " + base.ToString();
        }
    }
}
