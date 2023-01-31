using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventers.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Payment Method does not meet length requirements.")]
        public string PaymentMethod { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Invalid Card Number.")]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Invalid CVC.")]
        public string CVC { get; set; }


        public int EventeeId { get; set; }
        public virtual Eventee Eventee { get; set; }
        public int EventerId { get; set; }
        public virtual EVENTER EVENTER { get; set; }
    }
}
