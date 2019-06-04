using System;
using System.Collections.Generic;

namespace try_catch
{
    class Program
    {

        /*
            1. Add the required classes to make the following code compile.
            HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

            2. Run the program and observe the exception.

            3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
                Print meaningful error messages in the catch blocks.
        */

        static void Main(string[] args)
        {

            // Create a few contacts
            Contacts bob = new Contacts()
            {
                FirstName = "Bob",
                LastName = "Smith",
                Email = "bob.smith@email.com",
                Address = "100 Some Ln, Testville, TN 11111"
            };
            Contacts sue = new Contacts()
            {
                FirstName = "Sue",
                LastName = "Jones",
                Email = "sue.jones@email.com",
                Address = "322 Hard Way, Testville, TN 11111"
            };
            Contacts juan = new Contacts()
            {
                FirstName = "Juan",
                LastName = "Lopez",
                Email = "juan.lopez@email.com",
                Address = "888 Easy St, Testville, TN 11111"
            };


            // Create an AddressBook and add some contacts to it
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(bob);
            addressBook.AddContact(sue);
            addressBook.AddContact(juan);

            // Try to addd a contact a second time
          try{
               addressBook.AddContact(sue);

           }
           catch {
               Console.WriteLine("uh oh, you made a mistake sir... or miss");

           }


            // Create a list of emails that match our Contacts
            List<string> emails = new List<string>() {
            "sue.jones@email.com",
            "juan.lopez@email.com",
            "bob.smith@email.com",
        };

            // Insert an email that does NOT match a Contact
            emails.Insert(1, "not.in.addressbook@email.com");


            //  Search the AddressBook by email and print the information about each Contact
        foreach (string email in emails)

            try
            {
                // List<string> emailIds = new List<string>() {0, 1, 2, 3};
                {

                    Contacts Contacts = addressBook.GetByEmail(email);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"Name: {Contacts.FullName}");
                    Console.WriteLine($"Email: {Contacts.Email}");
                    Console.WriteLine($"Address: {Contacts.Address}");
                }
            }
                catch
                 (KeyNotFoundException)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Something went wrong!");
            }

            }
        }
    }


