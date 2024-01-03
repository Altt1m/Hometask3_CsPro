using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    internal interface ISort
    {
        public void SortAsc(); // сортування за зростанням
        public void SortDesc(); // сортування за спаданням
        public void SortByParam(bool isAsc); // сортування залежно від параметру
        /*
            Якщо isAsc дорівнює true, сортуємо за зростанням.
            Якщо isAsc дорівнює false, сортуємо за зменшенням
        */
    }
}
