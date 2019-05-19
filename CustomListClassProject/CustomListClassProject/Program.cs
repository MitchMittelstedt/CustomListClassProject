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
            CustomList<int> reducedListOneAndTwo = new CustomList<int>();
            int expected;
            int actual;
            listOne.Add(0);
            listOne.Add(9);
            listOne.Add(2);
            listTwo.Add(0);
            listTwo.Add(1);
            listTwo.Add(2);
            reducedListOneAndTwo = listOne - listTwo;
            expected = 9;
            actual = reducedListOneAndTwo[0];

        }
    }
}

