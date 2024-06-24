using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Services
{
    class PhoneBookService
    {
         public static List<PhoneBookModel> phoneContact = new List<PhoneBookModel>();
        public static void ShowAllContact()
        {
            if (phoneContact.Count == 0)
            {
                Console.WriteLine("Your Contact is Empty!");
            }
            else
            {
                for (int i = 0; i < phoneContact.Count; i++)
                {
                    Console.WriteLine($"{i+1}. Name {phoneContact[i].authorName} Phonne number is {phoneContact[i].phoneNumber}");
                }
            }
        }
        public static void AddContact()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter phone number");
            string number = Console.ReadLine();

            phoneContact.Add(new PhoneBookModel { phoneNumber = number, authorName = name });
            Console.WriteLine("Contact succesfully added");
        }
    }
}
