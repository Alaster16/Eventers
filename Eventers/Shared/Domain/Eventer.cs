using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eventers.Shared.Domain
{
    public class EVENTER : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Event Title does not meet length requirements.")]
        public string Title { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Event Location does not meet length requirements.")]
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int TicketPrice { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
