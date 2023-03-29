using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class Ring
    {
        public int size;
        public int postition = 0;

        public Ring(int size, int postition)
        {
            this.size = size;
            this.postition = postition;
        }

        public void MoveRing(int moveBy)
        {
            postition += moveBy;
            string space = new string(' ', postition);
            string shape = new string('■', size);
            Console.Clear();
            Console.Write(space);
            Console.Write(shape);
            
        }
    }
}
