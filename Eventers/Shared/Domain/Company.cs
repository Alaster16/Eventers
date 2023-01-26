using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventers.Shared.Domain
{
    public class Company : BaseDomainModel
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyAdress { get; set; }
        public int CompanyNumber { get; set; }
    }
}
