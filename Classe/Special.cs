using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classe
{
    public class Special : Cell
    {
        protected bool ModifyBudget(Player player, int amount)
        {
            int abs = Math.Abs(amount);

            if (player.Balance < abs)
            {
                return false;
            }
            else
            {
                if (amount >= 0)
                {
                    player.Balance += abs;
                }

                else
                {
                    player.Balance -= abs;
                }

                return true;
            }
        }
    }
}
