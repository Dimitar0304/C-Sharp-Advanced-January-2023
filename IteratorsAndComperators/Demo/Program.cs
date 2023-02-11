using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //custom IEnumerable<T> for custom class
            Guest pesho = new Guest();
            pesho.Name = "Pesho";
            pesho.Age = 18;

            Guest gosho = new Guest();
            gosho.Name = "gosho";
            gosho.Age = 20;

            Guest dimitrichko = new Guest();
            dimitrichko.Name = "dimitrichko";
            dimitrichko.Age = 22;


            Party party = new Party();
            party.Add(pesho);
            party.Add(gosho);
            party.Add(dimitrichko);

            foreach (var guest in party)
            {
                Console.WriteLine(guest.ToString());
            }
        }
        class Guest
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{this.Name} -> {this.Age}";
            }
        }
        class Party:IEnumerable<Guest>
        {
            List<Guest> _guests;
            public Party()
            {
                _guests = new List<Guest>();
            }
           
            public void Add(Guest guest)
            {
                _guests.Add(guest);
            }
            public IEnumerator<Guest> GetEnumerator()
            {
                foreach (var guest in _guests)
                {
                    yield return guest;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            //everyone guest can be invited to the party
            
        }
    }
}
