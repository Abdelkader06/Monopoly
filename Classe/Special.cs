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
            int montant = Math.Abs(amount);
            if (amount < 0)
                return player.RetrieveMoney(montant);
            else
                player.ReceiveMoney(montant);
            return true;
        }
    }
}
