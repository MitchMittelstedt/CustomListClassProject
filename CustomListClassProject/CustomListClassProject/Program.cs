using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected;
            int actual;
            //ACT
            listOne.Add(0);
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(0);
            listTwo.Add(1);
            listTwo.Add(2);
            listTwo.Add(3);

            listOne.Zip(listTwo);
            expected = 3;
            actual = listOne[6];

        }
    }
}

