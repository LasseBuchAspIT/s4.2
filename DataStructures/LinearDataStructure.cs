using System;

namespace DataStructures
{
    public abstract class LinearDataStructure<T>
    {
        T[] data;
        protected int length;
        protected int count;
        protected int elements;

        protected LinearDataStructure(int initialLength)
        {
            data = new T[initialLength];
            length = initialLength;
        }

        protected void Insert(T itemToInsert, int index)
        {
            data[index] = itemToInsert;

            if (!data.Contains(itemToInsert))
            {
                count++;
            }
                elements++;
        }

        //moving method
        //useful for inserting
        protected void MoveAll(int from)
        {
            T Last = default(T);
            if(from < length)
            {
                if(elements >= length)
                {
                    ReSize(length + 20);
                    length += 20;
                }

                
               for(int i = from; from < elements + 1; i++)
               {
                    T tmp = data[i];
                    data[i] = Last;
                    Last = tmp;
               }
            }

        }

        protected void ReSize(int newSize)
        {
            if(newSize < length)
            {
                throw new ArgumentOutOfRangeException("array cannot be made smaller");
            }
            T[] newData = new T[newSize];
            for(int i = 0; i < length; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }

        protected void Remove(int index)
        {

        }


    }
}
