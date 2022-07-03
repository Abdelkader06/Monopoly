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
            //TODO
            throw new NotImplementedException();
        }
        private int GetInput(Player player, Property property)
        {
            //TODO
            throw new NotImplementedException();
        }
        public void BuyProperty(Property property, Player player, int input)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool OnRegular(Cell cell, Player player)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool OnTax(Tax tax, Player player)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool PlayRound(Player player)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool PlayerWon()
        {
            //TODO
            throw new NotImplementedException();
        }

        public void PlayerLost(Player player)
        {
            //TODO
            throw new NotImplementedException();
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
