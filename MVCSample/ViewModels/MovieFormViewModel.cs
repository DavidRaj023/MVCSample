using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movies Movies { get; set; }
    }
}