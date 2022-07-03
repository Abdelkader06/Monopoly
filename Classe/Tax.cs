using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classe
{
    public class Tax : Special
    {
        #region Proprities
        private int amount;
        public int Amount
        {
            get { return amount; }
        }
        #endregion
        public Tax(int amount, int position)
        {
            this.amount = amount;
            this.position = position;
        }

        public bool TaxPlayer(Player player)
        {
            if (player.Balance >= amount)
            {
                player.Balance -= amount;

                return true;
            }

            else
            {
                return false;
            }
        }

        /*
        public override string ToString()
        {
            return "[Tax]: " + this.amount + "£";
        }
        */
    }
}
