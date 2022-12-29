using Consolo_Project_3.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo_Project_3.sevices
{
    internal class EmployeeService : Employee
    {
        public EmployeeService(string name, string surname, int age, string adress, Department department) : base(name, surname, age, adress, department)
        {
        }

        public void CreateEmployee()
        {
            Console.Write("Please enter the name:");
            string name = Console.ReadLine();
            Console.Write("Please enter the surname:");
            string surname = Console.ReadLine();
            Console.Write("Please enter the employee's age:");
            int age;
        againAge:
            bool agebool = int.TryParse(Console.ReadLine(), out age);
            if (agebool == false || age < 0)
            {
                Console.Write("Please enter valid symbol:");
                goto againAge;
            }
            Console.Write("Pleae enter the adress");
            string adress = Console.ReadLine();
        department:
            Console.WriteLine("Please enter the Department name");
            string dname = Console.ReadLine();
            foreach (Department department in Department.company.Departments)
            {
                if (department.name == dname)
                {
                    Employee employee = new Employee(name, surname, age, adress, department);
                    Console.WriteLine("Employee was successfully added");
                }
            }
            Console.WriteLine("Deparment not found");
            goto department;

        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Choose the Department");

            int count = 1;
            foreach (Department department in Department.company.Departments)
            {
                Console.WriteLine(count + ". " + department.name);
            }
            int num;
        againSelect:
            bool numbool = int.TryParse(Console.ReadLine(), out num);
            if (numbool == false || num > Department.company.Departments.Length || num <= 0)
            {
                Console.WriteLine("Plese insert valid number");
                goto againSelect;
            }
            Console.WriteLine("Choose the Employee");

            foreach (Employee employee in Department.company.Departments[num - 1].employees)
            {
                Console.WriteLine(count + ". " + employee.name);
            }
            int num2;
        againSelect2:
            bool num2bool = int.TryParse(Console.ReadLine(), out num2);
            if (num2bool == false || num2 > Department.company.Departments.Length || num2 <= 0)
            {
                Console.WriteLine("Plese insert valid number");
                goto againSelect2;
            }
        changed2:
            Console.WriteLine("What do you want to change about the employee?  Name/Surname/Age/Adress/Department");
            string change = Console.ReadLine().ToLower();
            switch (change)
            {
                case "name":
                    Console.WriteLine("Enter the new name");
                    string name = Console.ReadLine();
                    Department.company.Departments[num - 1].employees[num2 - 1].name = name;
                    Console.WriteLine("Name was successfully changed");
                    break;
                case "surname":
                    Console.WriteLine("Enter the new surname");
                    string surname = Console.ReadLine();
                    Department.company.Departments[num - 1].employees[num2 - 1].surname = surname;
                    Console.WriteLine("Surname was successfully changed");
                    break;
                case "age":
                    Console.WriteLine("Enter the new age");
                    int age;
                againAge:
                    bool agebool = int.TryParse(Console.ReadLine(), out age);
                    if (agebool == false || age < 0)
                    {
                        Console.Write("Please enter valid symbol:");
                        goto againAge;
                    }
                    Department.company.Departments[num - 1].employees[num2 - 1].age = age;
                    Console.WriteLine("Age was successfully changed");
                    break;

                case "adress":
                    Console.WriteLine("Enter the new adress");
                    string adress = Console.ReadLine();
                    Department.company.Departments[num - 1].employees[num2 - 1].adress = adress;
                    Console.WriteLine("Adress was successfully changed");
                    break;
                case "department":
                    Console.WriteLine("Choose the Department");

                    int count1 = 1;
                    foreach (Department department in Department.company.Departments)
                    {
                        Console.WriteLine(count1 + ". " + department.name);
                    }
                    int num3;
                againSelect3:
                    bool num3bool = int.TryParse(Console.ReadLine(), out num3);
                    if (num3bool == false || num3 > Department.company.Departments.Length || num3 <= 0)
                    {
                        Console.WriteLine("Plese insert valid number");
                        goto againSelect3;
                    }
                    Department.company.Departments[num - 1].employees[num2 - 1].department = Department.company.Departments[num3 - 1];
                    Console.WriteLine("Department successfully changed");
                    break;

                default:
                    Console.WriteLine("Please enter valid number");
                    goto changed2;
                    break;
            }
        }
        public void GetEmployeeByID()
        {
            Console.WriteLine("Choose the Department");

            int count = 1;
            foreach (Department department in Department.company.Departments)
            {
                Console.WriteLine(count + ". " + department.name);
            }
            int num;
        againSelect:
            bool numbool = int.TryParse(Console.ReadLine(), out num);
            if (numbool == false || num > Department.company.Departments.Length || num <= 0)
            {
                Console.WriteLine("Plese insert valid number");
                goto againSelect;
            }
            Console.Write("Please insert employee ID:");
            int ID;
            bool idbool = int.TryParse(Console.ReadLine(), out ID);
            foreach (Employee employee in Department.company.Departments[num - 1].employees)
            {
                if (employee.id == ID)
                {
                    Console.WriteLine(employee);
                    return;
                }
            }
            Console.WriteLine("Employee not found");

        }

        public void GetEmployeeByAge()
        {
            Console.WriteLine("Choose the Department");

            int count = 1;
            foreach (Department department in Department.company.Departments)
            {
                Console.WriteLine(count + ". " + department.name);
            }
            int num;
        againSelect:
            bool numbool = int.TryParse(Console.ReadLine(), out num);
            if (numbool == false || num > Department.company.Departments.Length || num <= 0)
            {
                Console.WriteLine("Plese insert valid number");
                goto againSelect;
            }
            Console.Write("Please insert employee Age:");
            int age;
            bool agebool = int.TryParse(Console.ReadLine(), out age);
            foreach (Employee employee in Department.company.Departments[num - 1].employees)
            {
                if (employee.age == age)
                {
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine("So many employees have been found");

        }

        public void GetEmloyeesByDepartmentsId()
        {
            Console.Write("Please insert department ID:");
            int ID;
            bool idbool = int.TryParse(Console.ReadLine(), out ID);
            foreach (Department department in Department.company.Departments)
            {
                if (department.id == ID)
                {
                    foreach (var item in department.employees)
                    {
                        Console.WriteLine(item);
                    }
                    return;
                }
            }
            Console.WriteLine("Department not found");
        }

        public void GetEmloyeesByDepartmentsName()
        {
            Console.Write("Please insert department name:");
            string name = Console.ReadLine();
            foreach (Department department in Department.company.Departments)
            {
                if (department.name == name)
                {
                    foreach (var item in department.employees)
                    {
                        Console.WriteLine(item);
                    }
                    return;
                }
            }
            Console.WriteLine("Department not found");
        }

        public void GetEmployeeByNameOrSurname()
        {
            Console.WriteLine("Choose the Department");

            int count = 1;
            foreach (Department department in Department.company.Departments)
            {
                Console.WriteLine(count + ". " + department.name);
            }
            int num;
        againSelect:
            bool numbool = int.TryParse(Console.ReadLine(), out num);
            if (numbool == false || num > Department.company.Departments.Length || num <= 0)
            {
                Console.WriteLine("Plese insert valid number");
                goto againSelect;
            }
            Console.Write("Please insert employee Name or Surname:");
            string find = Console.ReadLine();
            foreach (Employee employee in Department.company.Departments[num - 1].employees)
            {
                if (employee.name == find || employee.surname == find)
                {
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine("So many employees have been found");

        }

        public void GetAllEmployees()
        {
            foreach (Department department in Department.company.Departments)
            {
                Console.WriteLine(department);
                foreach (Employee employee in department.employees)
                {
                    Console.WriteLine(employee);
                }

            }
        }

        public void EmployeeDelete()
        {
            Console.WriteLine("Choose the Department");

            int count = 1;
            foreach (Department department in Department.company.Departments)
            {
                Console.WriteLine(count + ". " + department.name);
            }
            int num;
        againSelect:
            bool numbool = int.TryParse(Console.ReadLine(), out num);
            if (numbool == false || num > Department.company.Departments.Length || num <= 0)
            {
                Console.WriteLine("Plese insert valid number");
                goto againSelect;
            }
            Console.Write("Please insert employee ID:");
            int ID;
            bool idbool = int.TryParse(Console.ReadLine(), out ID);
            foreach (Employee? employee in Department.company.Departments[num - 1].employees)
            {
                if (employee.id == ID)
                {
                    Console.WriteLine(employee + " deleted");
                    employee.name = null;
                    employee.surname = null;
                    employee.age = 0;
                    employee.adress = null;
                    employee.department = null;

                }
            }
            Console.WriteLine("Employee not found");

        }
    }

}
