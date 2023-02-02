using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Eventers.Shared.Domain
{
    public class Eventee : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements.")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Address does not meet length requirements.")]
        public string Address { get; set; }
        [Required]
        [RegularExpression(@"^[STFG][0-9]{7}[A-Z]$", ErrorMessage = "NRIC does not meet length requirements.")]
        public string NRIC { get; set; }
        [Required]
        public int DateOfBirth { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage ="Contact Number is not a valid phone number.")]
        public int ContactNumber { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Gender does not meet the length requirement.")]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email Address is not a valid email.")]
        public string Email { get; set; }
    }
}
