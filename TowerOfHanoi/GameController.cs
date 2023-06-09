﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        private int SelectedTower; 
        private int SelectedRingTower;
        private string msg = "";


        public GameController(int ringCount)
        {
            this.ringCount = ringCount;
            SquareSize = ringCount + (ringCount - 1); 
            SelectedTower = 0;

            for(int i = ringCount + (ringCount - 1); i >= 1; i -= 2)
            {
                towers[0].add(new Ring(i));
            }
        }

        public void Draw()
        {
            Console.Clear();
            Console.WriteLine(msg);
            Console.WriteLine();
            Console.WriteLine();
            for (int i  = ringCount; i > 0; i--)
            {
                Console.WriteLine();
                foreach (Tower t in towers)
                {
                    if (t == towers[SelectedTower])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (t.rings.Count >= i)
                    {
                        if(t.rings[i - 1] == SelectedRing)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        string output = new string(' ' ,(SquareSize - t.rings[i - 1].size) / 2) + new string('■', t.rings[i - 1].size) + new string(' ', (SquareSize - t.rings[i - 1].size) / 2);
                        Console.Write("|" + output + "|");
                    }
                    else
                    {
                        Console.Write("|"); 
                        Console.Write(new String(' ', SquareSize));
                        Console.Write("|");
                    }
                        Console.ForegroundColor = ConsoleColor.White;
                }
            }
            msg = "";
        }



        //entire game executes from here
        public void GameLoop()
        {
            //while all rings arent on the end tower
            while(towers[2].rings.Count != ringCount)
            {
                //Draw scene
                Draw();
                ConsoleKey action = Console.ReadKey().Key;
                if(action == ConsoleKey.Enter)
                {
                    if(SelectedRing != null)
                    {
                        try
                        {
                            towers[SelectedRingTower].moveTop(towers[SelectedTower]);
                        }
                        catch
                        {
                            msg = "Cant place on top of smaller ring";
                        }
                            SelectedRing = null;

                    }
                    else
                    {
                        if(towers[SelectedTower].rings.Count != 0)
                        {
                            SelectedRing = towers[SelectedTower].rings.Last();
                            SelectedRingTower = SelectedTower;
                        }
                        else
                        {
                            msg = "the rings you are looking for are in another tower";
                        }
                    }
                }
                else if(action == ConsoleKey.RightArrow)
                {
                    if(SelectedTower >= 2)
                    {
                        msg = "cant go any further right";
                    }
                    else
                    {
                        SelectedTower++;
                    }
                }
                else if(action == ConsoleKey.LeftArrow)
                {
                    if (SelectedTower == 0)
                    {
                        msg = "cant go any further left";
                    }
                    else
                    {
                        SelectedTower--;
                    }
                }
            }
            msg = "Congratulations! you win";
            Draw();
        }

    }
}
