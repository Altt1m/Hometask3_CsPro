using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    internal interface IOutput
    {
        public void Show(); // відображає інформацію
        public void Show(string info); // відображає інформацію та інформаційне повідомлення, зазначене у параметрі info.
    }
}
