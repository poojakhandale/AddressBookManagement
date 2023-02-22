// See https://aka.ms/new-console-template for more information
using AdressBook_Management;

public class Program
{
    public static void Main(string[] args)
    {
        AddressBook myAddressBook = new AddressBook();
        Contact newContact = new Contact("pooja", "KHANDALE", "INDIA", "9152325451", "pOOJA.p@example.com");
        Contact newContact1 = new Contact("rani", "JADHAV", "INDIA", "901254784", ".p@example.com");
        Contact newContact2 = new Contact("MONA", "JOHN", "USA", "8885550000", "tony.stark@tech.com");
        myAddressBook.AddContact(newContact);
        myAddressBook.AddContact(newContact1);
        myAddressBook.AddContact(newContact2);
        myAddressBook.PrintContacts();

        myAddressBook.DeleteContact("MONA ", "JOHN");
        myAddressBook.PrintContacts();



    }
}


