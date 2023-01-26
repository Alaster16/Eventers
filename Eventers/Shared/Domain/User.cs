using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventers.Shared.Domain
{
    public class User : BaseDomainModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NRIC { get; set; }
        public int DateOfBirth { get; set; }
        public int ContactNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
