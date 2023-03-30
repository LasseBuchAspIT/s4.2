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
        int SquareSize;
        int ringCount;
        private Tower[] towers = new Tower[3] { new(), new(), new() };

        public GameController(int ringCount)
        {
            this.ringCount = ringCount;
            SquareSize = ringCount + 4; 
            
            for(int i = ringCount + 2; i >= 1; i -= 2)
            {
                towers[0].add(new Ring(i));
            }
        }

        public void Draw()
        {
            for(int i  = ringCount; i > 0; i--)
            {
                Console.WriteLine();
                foreach(Tower t in towers)
                {
                    if(t.rings.Count >= i)
                    {
                        string output = new string(' ' ,(SquareSize - t.rings[i - 1].size) / 2) + new string('■', t.rings[i - 1].size) + new string(' ', (SquareSize - t.rings[i - 1].size) / 2);
                        Console.Write("|" + output + "|");
                    }
                    else
                    {
                        Console.Write("|");
                        Console.Write(new String(' ', SquareSize));
                        Console.Write("|");
                    }
                }
            }
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
