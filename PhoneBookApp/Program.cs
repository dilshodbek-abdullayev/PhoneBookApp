using PhoneBookApp.Services;
using System;

namespace PhoneBookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome my PhoneBook program");

            bool isTrue = true;
            while (true)
            {
                Console.WriteLine("\t\t\t\t\tMenu:");
                Console.WriteLine("1. My contacts");
                Console.WriteLine("2. Add contact");
                Console.WriteLine("3. Edit by Id contact");
                Console.WriteLine("4. Delete by Id contact");
                Console.WriteLine("5. Exit Program\n");

                Console.WriteLine("Choose you wanted:");

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());

                    switch(input)
                    {
                        case 1: PhoneBookService.ShowAllContact();break;
                        case 2: PhoneBookService.AddContact();break;
                        case 3: PhoneBookService.UpdateByIdContact();break;
                        case 4: PhoneBookService.DeleteById();break;
                        case 5: isTrue = false; break;
                        default : Console.WriteLine("Check input number");break;

                        
                    }

                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}