using System;
using System.Collections.Generic;

namespace try_catch
{
    class AddressBook
    {

           Dictionary<string, Contacts> addressBook { get; set; }= new Dictionary<string, Contacts>();

            public void AddContact(Contacts person){
                addressBook.Add(person.Email, person);
            }

            public Contacts GetByEmail(string Email) {

                return addressBook[Email];
            }


    }

}