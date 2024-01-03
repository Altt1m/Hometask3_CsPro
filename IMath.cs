using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hometask3
{
    internal interface IMath
    {
        int Max(); // повертає максимум
        int Min(); // повертає мінімум
        float Avg(); // повертає середнє значення
        bool Search(int valueToSearch); // шукає valueSearch всередині контейнера даних.
        /*
            - Повертає true, якщо значення знайдено.
            - Повертає false, якщо значення не знайдено.
        */
    }
}
