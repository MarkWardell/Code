using DataStructLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataStructLib
{
    public class Event
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id              { get; set; }
        public DateTime EventDate   { get; set; } 
        public string Location      { get; set; }
        public Venue Venue         { get; set; }
        public float Cover          { get; set; }
        public List<Talent> Talent  { get; set; }
    }
    
    public class Address
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id                  { get; set; }
        public string Address1          { get; set; }
        public string Address2          { get; set; }
        public string City              { get; set; }
        public US_State State           { get; set; }
        public List<PhoneNumber> PhoneNumber { get; set; }

    }

    public enum PhoneType
    {
        Main,
        Cell,
        Other
    }
    public class PhoneNumber
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string Number { get; set; }
        public PhoneType Type { get; set; }

    }
    public class Venue
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address VenueAddress         { get; set; }
        public List<PhoneNumber>  Phone     { get; set; }
        public List<Person> ContactPersons { get; set; }
    }

    public class Talent
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public Person Contact{ get; set; }
        public Address VenueAddress { get; set; }
        
    }

    //public enum ContactType { Primary, Secondary}
    //public enum Role { Manager, BarTender, BandLeader, Doorman, Unknown}
    public class Person
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public enum ContactType { Primary, Secondary }
        public enum Role { Manager, BarTender, BandLeader, Doorman, Unknown }
        public ContactType Type { get; set; }
        public Role ContactRole { get; set; }
        public List<PhoneNumber> Phone { get; set; }
    }
}
