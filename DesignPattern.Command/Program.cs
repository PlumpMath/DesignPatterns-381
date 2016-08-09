using System;
using System.Collections.Generic;

namespace DesignPattern.Command
{
    class Program
    {
        static void Main()
        {
            //prepare address test data
            Address address = new Address
                                          {
                                              Street = "Hello St",
                                              Locality = "Hello",
                                              State = "HLO",
                                              PostCode = "1111",
                                              Country = "XX"
                                          };
            //prepare person test data
            Person person = new Person
                                 {
                                     FirstName = "John", 
                                     LastName = "Smith", 
                                 };

            //test if person is valid
            bool isPersonValid = person.IsValid();
            Console.WriteLine(string.Format("Person validation : {0}", isPersonValid));
            Console.WriteLine("============================================");

            //test if address is valid
            bool isAddressValid = address.IsValid();
            Console.WriteLine(string.Format("Address validation : {0}", isAddressValid));
            Console.WriteLine("============================================");

            List<IValidatable> validatableItems = new List<IValidatable>();
            validatableItems.Add(person);
            validatableItems.Add(address);

            foreach (IValidatable validatableItem in validatableItems)
            {
                Console.WriteLine(string.Format("Item is validation is {0}", validatableItem.IsValid()));
            }
        }
    }
}
