using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Sample.Models
{
    public class TodoItem
    {
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public Boolean IsComplete { get; set; }
    }
}
