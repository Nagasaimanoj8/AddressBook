using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook2
{
    class Edit  // Class Edit
    {
        /// <summary>
        /// Welcome to Address Book Management System
        /// //UC1-C
        /// </summary>
        /// <param name="args">The arguments.</param>

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book");
            //calling operation management class that contains operation
            OperationManagement.AddDetails();
            Console.Read();
        }
    }
}
