using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object
            AddressBookSystem addressBook = new AddressBookSystem();

            Console.WriteLine("\n************\nWELCOME TO ADDRESS BOOK PROGRAM\n************\n");
            addressBook.ChooseOption();
        }
    }
}
