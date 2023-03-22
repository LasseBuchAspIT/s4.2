using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LiFo
    {
        private LinkedList<int> list;

        //insert at first index
        public void push(int num)
        {
            list.AddFirst(num);
        }

        //remove and return first item
        public int pop()
        {
            int returnNum = 0;
            returnNum = list.Last();
            list.RemoveLast();
            return returnNum;
        }
    }
}
