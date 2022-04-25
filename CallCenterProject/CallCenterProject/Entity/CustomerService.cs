using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.Entity
{
    public class CustomerService: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public Type CustomerType { get; set; }
        public bool Statu { get; set; } = true;



    }
}
