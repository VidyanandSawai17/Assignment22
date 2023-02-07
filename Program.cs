using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    public class Program
    {
        static void Main(string[] args)
        {

        EmployeeCRUD employeeCRUD = new EmployeeCRUD();
            int c = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Empoyee List");
                Console.WriteLine("2. Add Empoyee");
                Console.WriteLine("3. Update Empoyee");
                Console.WriteLine("4. Delete Empoyee");
                Console.WriteLine("5. Display Product By Id");

                Console.WriteLine("select above option");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                        case 1: 
                        List<Employee> emp = employeeCRUD.List();
                        Console.WriteLine("Id \t Name \t\tSalary");
                        foreach (Employee item in emp)
                        {
                            Console.WriteLine($"{item.id} \t {item.name} \t\t{item.salary}");
                        }
                        break;

                        case 2:
                        Employee p1 = new Employee();
                        Console.WriteLine("Enter Id");
                        p1.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee name");
                        p1.name = Console.ReadLine();
                        Console.WriteLine("Enter salary");
                        p1.salary = Convert.ToInt32(Console.ReadLine());
                        employeeCRUD.AddEmployee(p1);
                        Console.WriteLine("Product added..");

                        break;

                        case 3:
                        Employee p2 = new Employee();
                        Console.WriteLine("Enter Id");
                        p2.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new Employee name");
                        p2.name = Console.ReadLine();
                        Console.WriteLine("Enter new salary");
                        p2.salary = Convert.ToInt32(Console.ReadLine());
                        employeeCRUD.UpdateEmployee(p2);
                        Console.WriteLine("Employee updated..");

                        break;

                        case 4:
                        Console.WriteLine("Enter Id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        employeeCRUD.DeleteEmployee(id);
                        Console.WriteLine("Product deleted..");

                        break;


                        case 5:
                        Console.WriteLine("Enter product id to search");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Employee employee = employeeCRUD.ViewEmployee(id2);
                        if (employee.id > 0)
                            Console.WriteLine($"Id = {employee.id} , Name ={employee.name}, Price= {employee.salary}");
                        else
                            Console.WriteLine("Product not found..");
                        break;


                        default:
                        Console.WriteLine("Wrong option selection..");
                        break;


                }
                Console.WriteLine("Select 1 for continue");
                c = Convert.ToInt32((Console.ReadLine()));
            }
            while (c==1);


        }
    }
}
