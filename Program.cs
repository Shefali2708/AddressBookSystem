using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">->->->->-> Welcome to Address Book Program <-<-<-<-<-<");
            //creating object of addressbook
            AddressBook addressBook = new AddressBook();
            //getting Op in Constructor with paratmers
            addressBook.addContacts("Shefali", "Sharma", "ABC", "Nagpur", "MH", 440018, 0123456789, "Yes@gmail.com");
            // called Print method 
            addressBook.print();
            Console.ReadLine();
        }
    }
}
