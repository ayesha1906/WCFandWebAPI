﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(string name);

        [OperationContract]
        string GetResult(int Sid, string Sname, int M1, int M2, int M3);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);
    }
}
