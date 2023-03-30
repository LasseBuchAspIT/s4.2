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
        int maxSquareSize;
        private Tower[] towers = new Tower[3];

        public GameController(int ringCount)
        {
            maxSquareSize = ringCount + 4; 
            for(int i = ringCount; i >= 1; i -= 2)
            {
                towers[0].add(new Ring(i));
            }
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
