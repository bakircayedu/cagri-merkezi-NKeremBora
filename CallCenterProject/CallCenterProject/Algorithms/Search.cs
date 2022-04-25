using CallCenterProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.Algorithms
{
    public  class Search
    {
        // girdigimiz metini bulunan nesneler in not ozelliginde arar bulursa nesnneyi listeye ekler ve listeyi doner.
        public  List<Call> LinearSearch(List<Call> list, string value)
        {
            List<Call> result = new();
            foreach(var item in list)
            {
                if (item == null)
                    break;
                if (item.ServiceNotes.Contains(value))
                {
                    result.Add(item);
                }
                
            }
            return result;
        }
    }

}
