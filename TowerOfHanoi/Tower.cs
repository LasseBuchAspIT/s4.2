using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class Tower
    {
        private List<Ring> rings = new List<Ring>();

        public void add(Ring ring)
        {
            if(ring.size  > 0)
            {
                rings.Add(ring);
            }
        }


    }
}
