using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_Diagram
{
    class Person
    {
        private string Name;
        private string Address;

        public string name
        {
            set { Name = value; }  // used to change value of the field

            get { return Name; }  // used to retur the value of the field


        }
        public string address
        {
            set { Address = value; }  // used to change value of the field

            get { return Address; }  // used to retur the value of the field

        }

        // constructer
        public Person(string name, string address)
        {
            Name = name;
            Address = address;

        }

        public Person()
        {
            Name = "";
            Address = "";

        }


        public override string ToString()
        {
            return "Name= " + name + "Address= " + address;
        }

    }
}
