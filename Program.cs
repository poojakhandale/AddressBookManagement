﻿// See https://aka.ms/new-console-template for more information
using AdressBook_Management;

public class Program
{
    public static void Main(string[] args)
    {
        AddressBook myAddressBook = new AddressBook();


        Console.WriteLine("Add new contact:");
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter country: ");
        string country = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        Contact newContact = new Contact(firstName, lastName, country, phoneNumber, email);

        myAddressBook.AddContact(newContact);
        Console.WriteLine("Contact Details: ");
        myAddressBook.PrintContacts();


    }
}



        
        
    


