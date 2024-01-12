using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlissBond.Shared.Domain
{
    public class User:BaseDomainModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string? Bio { get; set; }
        public string? Nickname { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public double Popularity { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Match>? Matches { get; set;}
    }
}
