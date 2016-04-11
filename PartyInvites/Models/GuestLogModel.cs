using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestLogModel
    {
        [Required (ErrorMessage = "Please Enter First Name")]
        public string FirstName { get; set; }

        [Required (ErrorMessage ="Please Enter Last Name")]
        public string LastName { get; set; }

        [Required (ErrorMessage ="Please Enter Email")]
        [RegularExpression (".+\\@.+\\..+", ErrorMessage ="Valid Email Needed!")]
        public string Email { get; set; }

        [Required (ErrorMessage ="Please Enter Contact Number")]
        [RegularExpression("\\(?\\d{3}\\)?-? *\\d{3}-? *-?\\d{4}", ErrorMessage ="Valid Phone Number Needed!")]
        public string Phone { get; set; }

        [Required (ErrorMessage ="Please Specify Weather You Will Attend")]
        public bool? WillAttend { get; set; }
    }
}