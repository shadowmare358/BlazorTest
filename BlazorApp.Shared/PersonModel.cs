using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Decimal AccountBalance { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
