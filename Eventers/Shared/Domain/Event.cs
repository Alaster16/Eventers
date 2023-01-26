using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventers.Shared.Domain
{
    public class Event : BaseDomainModel
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
}
}
