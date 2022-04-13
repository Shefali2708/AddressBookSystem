using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        internal static System.Collections.Generic.Dictionary<string, Contact> addressBookDict = new Dictionary<string, Contact>();

        internal static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Enter the Address Book Name or Enter Name of the saved Address Book");
            string addressBookName = Console.ReadLine();
            Refactor.AddressBookRefactor(addressBookName);
        }
    }
}
