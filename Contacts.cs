﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    //model class
    public class Contacts
    {
        //properties
        //by using encapsulation
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public double phonenumber { get; set;}
        public string email { get; set; }
    }
}
