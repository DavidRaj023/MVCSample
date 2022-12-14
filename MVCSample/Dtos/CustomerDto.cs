using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSample.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public DateTime? BirthDate { get; set; }
        
        public bool IsSubscribedToNewsletter { get; set; }
        
        public int MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}