using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public class vmCustomer
    {
        public int? CustomerId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public decimal? Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public bool IsActive { get; set; }
    }

    public class vmContactPerson
    {
        public int? CustConPerId { get; set; }
        public int? CustomerId { get; set; }
        public string ConPerName { get; set; }
        public string ConPerPhone { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
