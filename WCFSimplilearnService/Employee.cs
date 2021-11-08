using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFSimplilearnService
{
    [MessageContract]
    public class Employee
    {
        [MessageBodyMember(Order = 1)]
        public string EmpName { get; set; }

        public string AccountDetails { get; set; }
    }
}
