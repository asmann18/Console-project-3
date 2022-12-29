using Consolo_Project_3.Class;
using Consolo_Project_3.sevices;

namespace Consolo_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DepartmentService departmentService = new DepartmentService("A",2);
            EmployeeService employeeService = new EmployeeService("a", "B", 123, "AS", departmentService);
            restart:
            Console.WriteLine("Welcome");
            Console.WriteLine("1- CreateDepartment");
            Console.WriteLine("2- UpdateDepartment");
            Console.WriteLine("3- DeleteDepartment");
            Console.WriteLine("4- GetDepartmentById");
            Console.WriteLine("5- GetDepartmentByName");
            Console.WriteLine("6- GetAllDepartmentsByCapacity");
            Console.WriteLine("7- GetAllDepartments");
            Console.WriteLine("8- CreateEmployee");
            Console.WriteLine("9- UpdateEmployee");
            Console.WriteLine("10- DeleteEmployee");
            Console.WriteLine("11- GetEmployeeByAge");
            Console.WriteLine("12- GetEmployeeByID");
            Console.WriteLine("13- GetEmployeeByNameOrSurname");
            Console.WriteLine("14- GetEmployeeByDepartmentID");
            Console.WriteLine("15- GetALlEmployee");
            Console.WriteLine("16- ExitProgram");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    departmentService.CreateDepartment();
                    goto restart;
                    break;
                case "2":
                    departmentService.UpdateDepartment();
                    goto restart;
                    break;

                case "3":
                    departmentService.DeleteDepartment();
                    goto restart;
                    break;
                case "4":
                    departmentService.GetDepartmentByID();
                    goto restart;
                    break;

                case "5":
                    departmentService.GetDepartmentByName();
                    goto restart;
                    break;

                case "6":
                    departmentService.GetDepartmentByCapacity();
                    goto restart;
                    break;

                case "7":
                    departmentService.GetAllDepartment();
                    goto restart;
                    break;

                case "8":
                    employeeService.CreateEmployee();
                    goto restart;
                    break;

                case "9":
                    employeeService.UpdateEmployee();
                    goto restart;
                    break;

                case "10":
                    employeeService.EmployeeDelete();
                    goto restart;
                    break;

                case "11":
                    employeeService.GetEmployeeByAge();
                    goto restart;
                    break;

                case "12":
                    employeeService.GetEmployeeByID();
                    goto restart;
                    break;

                case "13":
                    employeeService.GetEmployeeByNameOrSurname();
                    goto restart;
                    break;

                case "14":
                    employeeService.GetEmloyeesByDepartmentsId();
                    goto restart;
                    break;

                case "15":
                    employeeService.GetAllEmployees();
                    goto restart;
                    break;

                case "16":
                    Console.WriteLine("GOodbye");
                    break;
                default:
                    Console.WriteLine("Please enter valid number");
                    goto restart;
                    break;
            }

        }
    }
}