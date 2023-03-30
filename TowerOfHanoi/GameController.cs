using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class GameController
    {
        int SquareSize;
        int ringCount;
        private Tower[] towers = new Tower[3] { new(), new(), new() };
        private Ring SelectedRing;
        private Tower SelectedTower;


        public GameController(int ringCount)
        {
            this.ringCount = ringCount;
            SquareSize = ringCount + 4; 
            SelectedTower = towers[0];

            for(int i = ringCount + 2; i >= 1; i -= 2)
            {
                towers[0].add(new Ring(i));
            }
        }

        public void Draw()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            for (int i  = ringCount; i > 0; i--)
            {
                Console.WriteLine();
                foreach (Tower t in towers)
                {
                    if(t.rings.Count >= i)
                    {
                        if(t.rings[i - 1] == SelectedRing)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if(t == SelectedTower)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        string output = new string(' ' ,(SquareSize - t.rings[i - 1].size) / 2) + new string('■', t.rings[i - 1].size) + new string(' ', (SquareSize - t.rings[i - 1].size) / 2);
                        Console.Write("|" + output + "|");
                        Console.ForegroundColor = ConsoleColor.White;
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
            //try to move ring and output alert if trying to make illegal move
            try
            {
                from.moveTop(to);
                //if success redraw scene
                Draw();

            }
            catch
            {

                Console.WriteLine("Cant place on top of smaller ring");
            }
             
        }


        //entire game executes from here
        public void GameLoop()
        {
            //while all rings arent on the end tower
            while(towers[2].rings.Count != ringCount)
            {
                //Draw scene
                Draw();


            }
        }

    }
}
