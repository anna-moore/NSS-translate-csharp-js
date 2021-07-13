using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Guest> guests = getGuests();
            Table table1 = new Table(new List<Guest>(), "Table 1");
            Table table2 = new Table(new List<Guest>(), "Table 2");
            List<Table> tables = new List<Table>(){
                table1, table2
            };

            foreach (Guest guest in guests)
            {
                IEnumerable<string> table1Occupations = table1.Guests.Select(g => g.Occupation);
                if (table1Occupations.Contains(guest.Occupation))
                {
                    table2.Guests.Add(guest);
                }
                else
                {
                    table1.Guests.Add(guest);
                }
            }

            foreach (Table table in tables)
            {
                Console.WriteLine(table.Name);
                foreach (Guest g in table.Guests)
                {
                    Console.WriteLine($"  {g.Name} {g.Occupation} {g.Bio}");
                }
            }



            List<Guest> getGuests()
            {
                return new List<Guest>(){
                    new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model"),
                    new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war"),
                    new Guest("Martin Luther King", "activist", "(1913 - 2005)  American civil rights activist"),
                    new Guest("Rosa Parks", "activist", "(1913 - 2005) American civil rights activist"),
                    new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian"),
                    new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology,\n  computer architecture, saved the world"),
                    new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC;\n  gave speeches on computer history, where she gave out nano-seconds"),
                    new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977")
                };
            }

        }
    }
}