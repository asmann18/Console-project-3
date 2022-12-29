using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Consolo_Project_3.Class
{
    internal class Employee
    {
        static int count = 0;
        public int id;
        public string name;
        public string surname;
        public int age;
        public string adress;
        public Department department;

        public Employee(string name,string surname,int age,string adress,Department department)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.adress = adress;
            this.department = department;
            this.id = ++count;
        }


      


    }
}
