using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiFo
{
    public class FiFo
    {
        private LinkedList<int> list = new LinkedList<int>();


        //insert at first index
        public void push(int num)
        {
            list.AddFirst(num);
        }

        //remove and return first item
        public int pop()
        {
            int returnNum = 0;
            returnNum =  list.First();
            list.RemoveFirst();
            return returnNum;
        }
    }
}
