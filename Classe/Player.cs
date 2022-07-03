using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classe
{
    public class Player
    {

        #region Proprites
        private List<Property> possessions;
        public List<Property> Possessions
        {
            get { return possessions; }
        }

        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private int position;
        public int Position
        {
            get { return position; }
        }
        private string name;
        public string Name
        {
            get { return name; }
        }
        public bool jailed;
        #endregion

        public Player(string name, int initialBalance, int initialPosition)
        {
            possessions = new List<Property>();
            this.name = name;
            this.balance = initialBalance;
            this.position = initialPosition;
        }
        public void ReceiveMoney(int amount)
        {
            balance += amount;
        }

        public bool RetrieveMoney(int amount)
        {
           if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
           else
            {
                return false;
            }
        }

        public bool Buy(Property p)
        {
            if (this.RetrieveMoney(p.Price))
            {
                possessions.Add(p);
                p.Owner = this;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Sell(Property p)
        {
            if (p.Owner != this)
                return false;
            else
            this.balance += p.Price;
            p.Owner = null;
            this.possessions.Remove(p);
            return true;
        }

        public bool TransferTo(Player p, int amount)
        {
            if (!this.RetrieveMoney(amount))
            {
                return false;
            }
            else
            {
                p.ReceiveMoney(amount);
                return true;
            }
        }

        public bool SellTo(Property p, Player player)
        {
            // vérfier si le joueur peut acheter le bien.
            if (p.Owner != this || player.Balance < p.Price)
            return false;
            this.Sell(p);
            player.Buy(p);
            return true;
        }

        

        public void Move(int vector,int boardSize)
        {
            // utiliser la méthode modulo 
            this.position = (this.position + vector) % boardSize;
            // utiliser une condition 
            /*
            this.position += vector;
            if(position == boardSize )
            {
                position = 0;
            }*/
        }

        public void SendToJail()
        {
            jailed = true;
        }

        
        public override string ToString()
        {
            string pos = this.possessions.Count > 0 ? this.possessions[0].Name : "";

            for (int i = 1; i < this.possessions.Count; i++)
                pos += ", " + this.possessions[i].Name;
            
            return "player: '" + this.name + "'\n"
                       + "balance: " + this.balance + " £\n"
                       + "position: " + this.position + "\n"
                       + "possessions: " + pos;
        }
    }
}
