using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainlayer.Models
{
    public class Employee :BaseEntity
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Department { get; set; }


    }
}
