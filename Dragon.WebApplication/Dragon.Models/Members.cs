using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.DomainClasses
{
    public class Member : IObjectWithState
    {
        public long Id { get; set; }
        //public Name Name { get; set; }
        public string AccountNumber { get; set; }
        //public Address Address { get; set; }
        public DateTime DateAdded { get; set; }
        public string Email { get; set; }
        public decimal SpendingLimit { get; set; }

        [NotMapped]
        public State State { get; set; }
    }
}
