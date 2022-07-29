using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customers Customers { get; set; }
    }
}