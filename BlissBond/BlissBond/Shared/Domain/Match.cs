using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlissBond.Shared.Domain
{
    public class Match:BaseDomainModel
    {
        public string MatchStatus { get; set; }
        public DateTime MatchDate { get; set; }
        public int User1Id { get; set; }
        public virtual User? User1{ get; set; }
        public int User2Id { get; set; }
        public virtual User? User2 { get; set; }
        
        

    }
    }

