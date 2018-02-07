using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_Diagram
{
    class Staff:Person
    {
        private string School;
        private double Pay;

        public Staff(string name, string address, string school, double pay):base(name, address)
        {
            School = school;
            Pay = pay;


        }

        public Staff() : base()
        {
            School = "";
            Pay = 0;


        }

        public override string ToString()
        {
            return "Name= "+name +"address="+ address+ "school= " + School + "pay= " + Pay;
        }


    }
}
