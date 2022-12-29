using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo_Project_3.Class
{
    internal class Department
    {
        static int count = 0;
        public int id;
        public string name;
        public int capacity;
        public Employee[] employees;
        public static Company company=new Company();

        public Department(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            this.id = ++count;
            employees = new Employee[0];
        }

        public void CreateDepartment()
        {
            Console.Write("Enter the Department name:");
            string name = Console.ReadLine();
            Console.Write("What is the capacity of the department?");
            int capacity;
        restart:
            bool capacitybool = int.TryParse(Console.ReadLine(), out capacity);
            if (capacitybool == false)
            {
                Console.WriteLine("Please enter valid number");
                goto restart;
            }
            Department department = new Department(name, capacity);
            Array.Resize(ref company.Departments, company.Departments.Length + 1);
            company.Departments[company.Departments.Length - 1] = department;
            Console.WriteLine("Department was successfully created");
        }
        public void UpdateDepartment()
        {
            int count = 1;
            foreach (Department department in company.Departments)
            {
                Console.WriteLine(count + ". " + department.name);
            }
            Console.Write("Enter the number of the department:");
            int num;
        againSelect:
            bool numbool = int.TryParse(Console.ReadLine(), out num);
            if (numbool == false || num > company.Departments.Length || num <= 0)
            {
                Console.WriteLine("Please insert valid number");
                goto againSelect;
            }
        again:
            Console.WriteLine("What do you want to update in the " + company.Departments[num - 1].name + " Department? Name/Capacity");
            string update = Console.ReadLine().ToLower();
            switch (update)
            {
                case "name":
                    Console.WriteLine("Enter the new name");
                    string name = Console.ReadLine();
                    company.Departments[num - 1].name = name;
                    Console.WriteLine("Name was successfully changed");
                    break;
                case "capacity":
                    Console.Write("What is the capacity of the department?");
                    int capacity;
                restart:
                    bool capacitybool = int.TryParse(Console.ReadLine(), out capacity);
                    if (capacitybool == false || company.Departments[num - 1].employees.Length > capacity)
                    {
                        Console.WriteLine("Please enter valid number");
                        goto restart;
                    }
                    company.Departments[num - 1].capacity = capacity;
                    Console.WriteLine("Capacity was successfully changed");

                    break;

                default:
                    Console.WriteLine("Please enter valid symbol");
                    goto again;

            }
        }

        public void DeleteDepartment()
        {
            int count = 1;
            foreach (Department department in company.Departments)
            {
                Console.WriteLine(count + ". " + department.name);
            }
            Console.Write("Select the Department you want to delete:");
            int num;
        againSelect:
            bool numbool = int.TryParse(Console.ReadLine(), out num);
            if (numbool == false || num > company.Departments.Length || num <= 0)
            {
                goto againSelect;
            }
            company.Departments[num - 1] = null;
            Console.WriteLine("Department was successfully deleted");
        }

        public void GetDepartmentByID()
        {
            Console.Write("Please enter department ID:");
            int id;
            restartID:
            bool idbool = int.TryParse(Console.ReadLine(), out id);
            if (idbool == false)
            {
                Console.WriteLine("Please enter valid symbol");
                goto restartID;
            }
            foreach (Department department in company.Departments)
            {
                if (department.id == id)
                {
                    Console.WriteLine(department);
                    return;
                }
            }
            Console.WriteLine("Department not found");
        }
        public void GetDepartmentByCapacity()
        {
            Console.Write("Please enter department capacity:");
            int capacity;
        restartCapacity:
            bool capacitybool = int.TryParse(Console.ReadLine(), out capacity);
            if (capacitybool == false)
            {
                Console.WriteLine("Please enter valid symbol");
                goto restartCapacity;
            }
            foreach (Department department in company.Departments)
            {
                if (department.capacity == capacity)
                {
                    Console.WriteLine(department);
                    return;
                }
            }
            Console.WriteLine("Department not found");
        }
        
        public void GetDepartmentByName()
        {
            Console.Write("Please enter department name:");
            string name = Console.ReadLine();
                foreach (Department department in company.Departments)
                {
                    if (department.name == name)
                    {
                        Console.WriteLine(department);
                        return;

                    }
                }
            Console.WriteLine("Department not found");
        }
        
        public void GetAllDepartment()
        {
            foreach (Department department in company.Departments)
            {
                Console.WriteLine(department);
            }
        }
        


    }
}
