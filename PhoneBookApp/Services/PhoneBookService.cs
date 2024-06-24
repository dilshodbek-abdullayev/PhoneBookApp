using PhoneBookApp.Models;
using System;
using System.Collections.Generic;

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
                    Console.WriteLine($"{i + 1}. Name {phoneContact[i].authorName} Phonne number is {phoneContact[i].phoneNumber}");
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
        public static void UpdateByIdContact()
        {
            ShowAllContact();
            Console.Write("Select the ID you want to change");
            int inputId = Convert.ToInt32(Console.ReadLine());
            if (inputId > 0 && inputId<= phoneContact.Count) 
            {
                inputId--;
                Console.Write("Enter name: ");
                phoneContact[inputId].authorName = Console.ReadLine();
                Console.Write("Enter number: ");
                phoneContact[inputId].phoneNumber = Console.ReadLine();

                Console.WriteLine("Contact successfully updated");
            }
            else
            {
                Console.WriteLine("Invalid ID number");
            }
        }
        public static void DeleteById()
        {

            ShowAllContact();
            Console.Write("Select the ID you want to delete");
            int inputId = Convert.ToInt32(Console.ReadLine());
            
            if(inputId > 0 && inputId<= phoneContact.Count)
            {
                inputId--;
                phoneContact.RemoveAt(inputId);
                Console.WriteLine("Successfully deleted");
            }
            else
            {

                Console.WriteLine("Invalid ID");
            }
        }

    }
}
