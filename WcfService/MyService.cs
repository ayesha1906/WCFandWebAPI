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

        public int GetMax(int[] ar)
        {
            int Max = ar[0];
            for(int i = 0;i< ar.Length; i++)
            {
                if (ar[i] > Max)
                    Max = ar[i];
            }

            return Max;
        }

        public string GetMessage(string name)
        {
            return "Hello Ms." + name;
        }

        public string GetResult(int Sid, string Sname, int M1, int M2, int M3)
        {
            double Avg = (M1 + M2 + M3) / 3.0;
            if (Avg < 35)
                return "Fail";
            else
                return "Pass";
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);
            return ar;
        }
    }
}
