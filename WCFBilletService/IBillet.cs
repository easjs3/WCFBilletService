﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;

namespace WCFBilletService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBillet
    {

        //[OperationContract]
        //string GetData(int value);
        // TODO: Add your service operations here
        [OperationContract]
        int MCPrisUdenRabatStorebælt();


        [OperationContract]
        int BilPrisUdenRabatStorebælt();


        [OperationContract]
        int BilPrisUdenRabatØresund();


        [OperationContract]
        int MCPrisUdenRabatØresund();

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }
    //}
}
