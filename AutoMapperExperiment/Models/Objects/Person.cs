using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperExperiment.Models.Objects
{
    public class Person
    {
        public Person()
        {
            Address = new Address();
        }

        public string Name { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }

    public class Car
    {
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}