using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.Entity
{
    public class Call:IEntity
    {
        public int Id { get; set; }
        public Type CallType { get; set; }
        public Customer Customer { get; set; }
        public CustomerService CustomerService { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ServiceNotes { get; set; }
    }
}
