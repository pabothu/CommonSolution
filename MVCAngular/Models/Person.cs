using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAngular.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Location { get; set; }
    }
}