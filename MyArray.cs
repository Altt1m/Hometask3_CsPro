using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    internal class MyArray : IOutput, IMath, ISort
    {
        private int[] _array;

        public MyArray(int[] array)
        {
            _array = array;
        }

        public void Show()
        {
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(info);
        }

        public int Max()
        {
            return _array.Max();
        }

        public int Min()
        {
            return _array.Min();
        }

        public float Avg()
        {
            return (float)(_array.Average());
        }

        public bool Search(int valueToSearch)
        {
            bool found = false;
            foreach (var item in _array)
            {
                if (item == valueToSearch)
                    found = true;
            }
            return found;
        }

        public void SortAsc()
        {
            Array.Sort(_array);
        }

        public void SortDesc()
        {
            Array.Sort(_array);
            Array.Reverse(_array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc(); 
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            int[] array = { 2, 1, 4, 3, 5 };
            MyArray arr = new MyArray(array);
            arr.Show();
            arr.Show("info");

            Console.WriteLine("\nTask 2:");
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Avg());
            Console.WriteLine(arr.Search(6));

            Console.WriteLine("\nTask 3:");
            arr.Show();
            arr.SortAsc(); arr.Show();
            arr.SortDesc(); arr.Show();
            arr.SortByParam(true); arr.Show();
        }
    }
}
