# **Phonebook Application**

Welcome to the Phonebook Application!

### Installation

1. Clone the repository to your PC 💻 
   
       https://github.com/dilshodbek-abdullayev/PhoneBookApp
   
## Usage

When you run the application, you will see a menu with the following options:

            Welcome to the Phonebook Application

            Menu:
            1. My contacts
            2. Add contact
            3. Edit contact
            4. Delete contact
            5. Exit Program

### Options

1. **My contacts**: This will display all the contacts in the phonebook.
```bash
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
```
2. **Add contact**: This will prompt you to add a new contact.
```bash
 public static void AddContact()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter phone number");
            string number = Console.ReadLine();

            phoneContact.Add(new PhoneBookModel { phoneNumber = number, authorName = name });
            Console.WriteLine("Contact succesfully added");
        }
```
3. **Edit contact**: This will prompt you to edit an existing contact.
```bash
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
```
4. **Delete contact**: This will prompt you to delete a contact.
```bash
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
```
5. **Exit Program**: This will exit the application.
