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
        public List<Ring> rings = new List<Ring>();

        public Tower()
        {
            rings = new List<Ring>();
        }

        public void add(Ring ring)
        {
            if(ring.size  > 0)
            {
                rings.Add(ring);
            }
        }

        public void moveTop(Tower destination)
        {
            if(destination.rings.Count == 0 || destination.rings.Last().size > rings.Last().size)
            {
                destination.add(rings.Last());
                rings.Remove(rings.Last());
            }
            else
            {
                throw new ArgumentException("Cant add ring on top of smaller ring");
            }
        }

    }
}
