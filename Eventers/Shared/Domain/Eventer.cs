using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eventers.Shared.Domain
{
    public class EVENTER : BaseDomainModel
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int TicketPrice { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
