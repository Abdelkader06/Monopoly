using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classe
{
    public class Street : Property
    {

        #region Champs

        private Color color;
        public enum Color
        {
            Red,
            Yellow,
            Blue,
            Brown,
        }
        #endregion


        public static Color ColorOfString(string str)
        {
            switch (str)
            {
                case "Red":
                    return Color.Red;
                case "Blue":
                    return Color.Blue;
                case "Brown":
                    return Color.Brown;
                case "Yellow":
                    return Color.Yellow;
                default:
                    throw new Exception("ColorOfString: '" + str + "'"
                                        + " is invalid color");
            }
        }

        //TODO

        public Street(string name, int price,
            int position, int rentCost, Color color) : base(name, price, position, rentCost)
        {
            this.name = name;
            this.price = price;
            this.position = position;
            this.rentCost = rentCost;
            this.color = color;
        }

        /*
        public override string ToString()
        {
            return "[Street] {" + this.color + "} " + base.ToString();
        }
        */
    }
}
