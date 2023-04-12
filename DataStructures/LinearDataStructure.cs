using System;

namespace DataStructures
{
    public abstract class LinearDataStructure<T>
    {
        T[] data;
        public int Length;
        public int Count;

        protected LinearDataStructure(int initialLength)
        {
            data = new T[initialLength];
        }

        public void Insert(T itemToInsert, int index)
        {
            data[index] = itemToInsert;
        }

        private void MoveAll(int from)
        {

        }


    }
}
