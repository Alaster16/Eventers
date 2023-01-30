using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventers.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string StaffName { get; set; }
        public string StaffEmail { get; set; }
        public int StaffNumber { get; set; }
    }
}
