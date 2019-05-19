using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>
    {
        //has
        private T[] items;
        public int Capacity { get { return capacity; } }
        private int capacity;
        public int Count { get { return count; } }
        private int count;

        public T this[int index]
        {
            get
            {
                // throw exception sometimes
                if (index <= count)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "What do you think you're doing?");                       
                }
            }
            set
            {
                if (index < count)
                {
                    items[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "What do you think you're doing?");
                }

            }
        }

        //constructor

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        //does

        public void Add(T itemToAdd)
        {
            items[count] = itemToAdd;
            count++;
            if (count == capacity)           
            {
                capacity *= 2;                 
                T[] newArray = new T[capacity];    
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];      
                }
                items = newArray;       
            }

        }

        public void Remove(T itemToRemove)
        {
            bool haveFoundItem = false;                       
            T[] newArray = new T[capacity];                     

            for (int i = 0; i < count; i++)            
            {
                if (items[i].Equals(itemToRemove))                   
                {
                    count--;                                           
                    newArray[i] = items[i + 1];                 
                    haveFoundItem = true;                              
                }
                else if(haveFoundItem)                              
                {
                    newArray[i] = items[i + 1];            
                }
                else
                {
                    newArray[i] = items[i];
                }
            }   
            items = newArray;                             
        }

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                newString += items[i].ToString();
            }
            return newString;
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo) 
        {                      
            CustomList<T> listOneAndTwo = new CustomList<T>();

            for (int i = 0; i < listOne.count; i++)
            {
                listOneAndTwo.Add(listOne.items[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                listOneAndTwo.Add(listTwo.items[i]);
            }
            return listOneAndTwo;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> reducedListOneAndTwo = new CustomList<T>();

            for (int i = 0; i < listOne.Count; i++)
            {
                for (int b = 0; b < listTwo.Count; b++)
                {
                    if (listOne[i].Equals(listTwo[b]))
                    {
                        listOne.Remove(listOne[i]);
                    }
                }
                reducedListOneAndTwo.Add(listOne[i]);
            }

            return reducedListOneAndTwo;
        }

        public void Zip(CustomList<T> items2Zip)
        {
            CustomList<T> zippedList = new CustomList<T>();
            T[] littleList = new T[capacity];
            T[] bigList = new T[capacity];

            int minCount;
            int maxCount;
            if (count > items2Zip.count)
            {
                minCount = items2Zip.count;
                maxCount = count;
                littleList = items2Zip.items;
                bigList = items;
            }
            else
            {
                minCount = count;
                maxCount = items2Zip.count;
                littleList = items;
                bigList = items2Zip.items;
            }
            int zippedListCount;
            zippedListCount = minCount + maxCount;
            for (int i = 0; i < minCount; i++)
            {
                zippedList.Add(littleList[i]);
                zippedList.Add(bigList[i]);
            }
            for (int i = minCount; i < maxCount; i++)
            {
                zippedList.Add(bigList[i]);
            }
            items = zippedList.items;
            count = zippedListCount;
        }
    }
}

