using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classe
{
    public abstract class Property : Cell
    {

        #region Champs

        private Player owner;
        public Player Owner
        {
            get { return owner; }
            set { owner = value; }
        } 
        protected int price;
        public int Price
        {
            get { return price; }
        }
        protected int rentCost;
        public int RentCost
        {
            get { return rentCost; }
        }

        protected string name;
        public string Name
        {
            get { return name; }
        }
        #endregion
        //TODO
        public Property(string name, int price, int position, int rentCost)
        {
            this.name = name;
            this.price = price;
            this.position = position;
            this.rentCost = rentCost;
        }

        /*
        public override string ToString()
        {
            return name + "; " + price + "; " + position + "; " + rentCost;
        }
        */
    }
}
