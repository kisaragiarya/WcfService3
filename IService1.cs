﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double add(double num1, double num2);

        [OperationContract]
        double sub(double num1, double num2);
        [OperationContract]
        double mul(double num1, double num2);
        [OperationContract]
        double div(double num1, double num2);
    }


  
}
