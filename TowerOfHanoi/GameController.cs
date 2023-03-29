using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class GameController
    {
        public Ring Selected = null;
        private string[,] map;

        private Tower StartTower;
        private Tower AuxTower;
        private Tower EndTower;

        public GameController(int ringCount)
        {
            //generate map from ringcount
        }

        public void Draw()
        {
            //draw new game scene
        }

        public void Move(Tower from, Tower to)
        {
            //check if moving to valid placement 

            //move from tower a to tower b
        }

        public void GameLoop()
        {
            //contain all logic for game and call from console
        }

    }
}
