﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EECS_448___Project_1
{
    public class Game
    {
        public int playerTurn = 1;
        public string playerOneName;
        public string playerTwoName;

        public List<int[,]> playerOneShips;
        public List<int[,]> playerTwoShips;

        public List<int[]> playerOneHits;
        public List<int[]> playerTwoHits;

        public List<int[]> playerOneMisses;
        public List<int[]> playerTwoMisses;

        public Game(string playerOneName, string playerTwoName)
        {
            this.playerOneName = playerOneName;
            this.playerTwoName = playerTwoName;

        }

        public bool isHit(int[] guess, int turn)
        {
            switch (turn)
            {
                case 1:
                    foreach (int[,] in playerTwoShips)
                    {

                    }
                    break;
                case 2:
                    foreach (int[,] in playerTwoShips)
                    {

                    }
                    break;

            }

            return true;
            
        }






    }
}