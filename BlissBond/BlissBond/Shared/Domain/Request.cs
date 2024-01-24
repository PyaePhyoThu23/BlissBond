using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlissBond.Shared.Domain
{
    public class Request:BaseDomainModel
    {
        public int requestorId { get; set; }
        public int recieverId { get; set; }
        public string? status { get; set; }
        public virtual ICollection<User>? Users { get; set; }

    }
}
