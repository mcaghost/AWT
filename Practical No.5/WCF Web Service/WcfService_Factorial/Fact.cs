using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService_Factorial
{
    [DataContract]
    class Fact
    {
        int num;
        [DataMember]
        public int Num
        {
            get{ return num; }
            set{ num = value; }
        }
    }
}
