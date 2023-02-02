using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Eventers.Shared.Domain
{
    public class Company : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Company Name does not meet length requirements.")]
        public string CompanyName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email.")]
        public string CompanyEmail { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Address does not meet length requirements.")]

        public string CompanyAddress { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number.")]
        public int CompanyNumber { get; set; }
    }
}
