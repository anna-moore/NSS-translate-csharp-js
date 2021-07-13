using System;
using System.Collections.Generic;

namespace DinnerParty
{
    public class Table
    {
        public List<Guest> Guests { get; set; }
        public string Name { get; set; }

        public Table(List<Guest> guests, string name)
        {
            Guests = guests;
            Name = name;
        }
    }
}