using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService_Factorial
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceFact : IFact
    {
        public string getFact(int num)
        {
            int  f = 1;
            for(int i=1;i<=num;i++)
            {
                f = f * i;
            }
            return f;
           
        }

       
    }
}
