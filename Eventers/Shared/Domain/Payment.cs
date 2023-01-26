using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventers.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public int PaymentID { get; set; }
        public string PaymentMethod { get; set; }
        public int CardNumber { get; set; }
        public int CVC { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int EventID { get; set; }
        public virtual Event Event { get; set; }
    }
}
