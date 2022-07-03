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
           if (balance > 0)
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
           if (balance >= p.Price)
            {
                balance -= p.Price;
                possessions.Add(p);
                return true;
            }

           else
            {
                return false;
            }
        }

        public bool Sell(Property p)
        {
            bool res = Buy(p);

            if (res)
            {
                balance += p.Price;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool TransferTo(Player p, int amount)
        {
            if (p.balance >= amount)
            {
                p.balance -= amount;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool SellTo(Property p, Player player)
        {
            if (player.balance>= p.Price)
            {
                player.balance -= p.Price;
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Move(int vector, int boardSize)
        {
            position += vector;
            if(position == boardSize)
            {
                position = 0;
            }
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
