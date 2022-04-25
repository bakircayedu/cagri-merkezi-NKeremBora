using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.Entity
{
    public class Customer: IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNo { get; set; }
        public Type CustomerType { get; set; }
    }
}
