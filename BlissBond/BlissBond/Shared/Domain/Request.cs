using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlissBond.Shared.Domain
{
    public class Request:BaseDomainModel
    {
        public int RequestorId { get; set; }
      
        public int RecieverId { get; set; }

        public string? Note { get; set; }
       
        public string? Status { get; set; }
        public virtual ICollection<User>? Users { get; set; }

       
    }
}
