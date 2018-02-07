using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_Diagram
{
    class Student : Person
    {
        private string Program;
        private int Year;
        private double Fee;



        public Student(string name, string address,string program, int year, double fee):base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student() : base()
        {
            Program = "";
            Year = 0;
            Fee = 0;
        }


        public override string ToString()
        {
            return "Name= "+ name + "address= "+ address + "program= " + Program + ", year= " + Year + "fee= " + Fee;
        }


    }
}
