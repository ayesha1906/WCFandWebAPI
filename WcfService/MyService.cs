using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    class MyService : IMyService
    {
        public string GetData()
        {
            return "Hello Ayesha !";
        }
    }
}
