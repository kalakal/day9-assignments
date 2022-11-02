using System;
using System.Runtime.InteropServices;

namespace AderessBook1
{
    class ContactPersons
    {
        private String firstName;

        private String address;
        private String lastName;
        private String city;
        private String email;
        private String state;
        private String zip;
        private String phoneNumber;

                public ContactPersons(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email)
        {
                  this.firstName = firstName;
                  this.lastName = lastName;
                  this.address = address;
                  this.zip = zip;
                  this.city = city;
                  this.state = state;
                  this.phoneNumber = phoneNumber;
                  this.email = email;
                }
        //Override
        public String toString()
        {
            return "In AddressBook" +
            "\n-------" +
               "\n FirstName=" + firstName +
               "\n LastName=" + lastName +
               "\n Address=" + address +
               "\n City=" + city +
               "\n State=" + state +
               "\n Zip=" + zip +
               "\n PhoneNumber=" + phoneNumber +
               "\n Email=" + email;
        }
    }
    public class AddressBookSystemMain
    {

        //Default Constructor

        public AddressBookSystemMain()
        {
            Console.WriteLine("Welcome to Address Book Program !!!");
        }
        public static void Main(String[] args)
        {
            //Initialize Object
            AddressBookSystemMain obj = new AddressBookSystemMain();

            //Calling Encapsulated Class object

            ContactPersons addressBook = new ContactPersons("SayedFaizan", "Faizan", "rajouri", "Jammu",

         "JAMMU AND KASHMIR", "185131", "9906276508", "sayedfaizanqadri@gmail.com");

            Console.WriteLine("\n" + addressBook.toString());

        }
    }
}    
