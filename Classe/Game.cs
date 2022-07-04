using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classe
{
    public class Game
    {
        private const int BeginCell = 200;

        private  List<Cell> board;
        public List<Cell> Board
        {
            get { return board; }
        }
        private int boardSize;
        public int BoardSize
        {
            get { return boardSize; }
        }
        private int playersNumber;
        public int PlayersNumber
        {
            get { return playersNumber; }
        }
        private List<Player> players;
        public List<Player> Players { 

            get { return players; }
        }

        public Game(int boardSize)
        {
            this.boardSize = boardSize;
            players = new List<Player>();
            board = new List<Cell>();
        }

      
        public int RollDice()
        {
          Random random = new Random();
          return random.Next(1, 13);
        }
        private int GetInput(Player player, Property property)
        {
            Console.WriteLine("No one owns the street you can buy it for {0}£, you have {1}£ left.\n" + " Press 1 if you want to buy it, 0 otherwise.",property.Price, player.Balance);
            string choice = Console.ReadLine();
            while (choice == null || choice != "0" && choice!= "1")
            {
                Console.WriteLine(" Please Press 1 if you want to buy it, 0 otherwise ");
                choice = Console.ReadLine(); 
            }

            return int.Parse(choice);
        }

        public void BuyProperty(Property property, Player player, int input)
        {
           if (input == 1)
            {
                if (player.Buy(property))
                {
                    Console.WriteLine("You bought " + property.Name + "your balance is now:" + player.Balance);
                }

                else
                {
                    Console.WriteLine("Insufficient funds");
                }
            }
        }

        public bool OnRegular(Cell cell, Player player)
        {
            // Caster la cell en type property
            Property property = (Property)cell;
            Console.WriteLine("You're now on the cell {0}", property.Name);

            if (property.Owner == null)
            {
                int input = this.GetInput(player,property);
                this.BuyProperty(property, player,input);
            }

            else if(property.Owner != player)
            {
                Console.WriteLine("This cell is owned by {0}, and the rent cost is {2}", property.Owner.Name, property.RentCost);
                bool transfert = player.TransferTo(property.Owner, property.RentCost);
                if (transfert)
                    Console.WriteLine("You paid {1} £, and your balance is {2} £", property.RentCost, player.Balance);
                else
                    PlayerLost(player);
                    return false;  
          }

            else
            {
                Console.WriteLine("you own this proprety");
            }

            return true;
        }

        public bool OnTax(Tax tax, Player player)
        {
            Console.WriteLine("You are now on a tax cell: you have to pay: {1} £", tax.Amount);
            if (tax.TaxPlayer(player))
            {
                Console.WriteLine("You paid : {1} £ , your balance is now {2} £ ", tax.Amount,player.Balance);
                return true;
            }
            else
            {
                this.PlayerLost(player);
                return false;
            }
        }

        public bool PlayRound(Player player)
        {
            //TODO
            throw new NotImplementedException();
        }
        
        public bool PlayerWon()
        {
            if(playersNumber == 1)
            {
                Console.WriteLine("Congratulations {0}, you won !", players[0].Name);
                return true;
            }

            else
            {
                return false;
            }
        }

       
        public void PlayerLost(Player player)
        {
            Console.WriteLine("You don't have enough money, you lost !");
            foreach(Property p in player.Possessions)
            {
                p.Owner = null;
            }
            player.Possessions.Clear();
            players.Remove(player);
            playersNumber--;
        }

        public void AddBoard(Cell cell)
        {
            boardSize++;
            board.Add(cell);
        }

        /*
        public void AddPlayer(Player player)
        {
            this.playersNumber++;
            this.players.Add(player);
        }
        */

        public void Play()
        {
            //TODO
            throw new NotImplementedException();
        }

        /*
        public void DisplayBoard()
        {
            int position = 0;
            foreach (Cell c in this.board)
            {
                Console.WriteLine(c);
                foreach (Player player in players)
                {
                    if (player.Position == position)
                        Console.WriteLine("\t* " + player.Name + " (" + player.Balance +
                                          "£)");
                }
                ++position;
            }
        }
        */
    }
}
