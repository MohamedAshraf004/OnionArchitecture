using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainlayer.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }

    }
}
