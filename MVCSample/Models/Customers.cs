using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSample.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        //[Min18YearIfAMember] Not Working Properly.
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }

    }
}