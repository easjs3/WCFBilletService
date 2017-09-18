using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;

namespace WCFBilletService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Billet : IBillet
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //mine forskellige objs 
        private Bil BilStoreBælt = new Bil(false);
        private MC MCStoreBælt = new MC(false);
        private Bil BilØresund = new Bil(true);
        private MC MCØresund = new MC(true);

        public int BilPrisUdenRabatStorebælt()
        {
            return BilStoreBælt.Pris();
        }


        public int MCPrisUdenRabatStorebælt()
        {
            return MCStoreBælt.Pris();
        }


        public int BilPrisUdenRabatØresund()
        {
            return BilØresund.Pris();
        }


        public int MCPrisUdenRabatØresund()
        {
            return MCØresund.Pris();
        }
    }
}
