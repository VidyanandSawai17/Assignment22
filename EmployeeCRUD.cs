using System.Collections.Generic;

namespace Assignment22
{
    public class EmployeeCRUD
    {
        public List<Employee> employee;
        internal int id;

        public EmployeeCRUD()
        {
            employee = new List<Employee>()
            {
                new Employee { id = 1, name = "Emp1", salary = 23550 },
                new Employee { id = 2, name = "Emp2", salary = 24550 },
                new Employee { id = 3, name = "Emp3", salary = 25550 }

            };
        }

        public void AddEmployee(Employee emp)
        {

            employee.Add(emp);

        }

        public void UpdateEmployee(Employee emp)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].id == emp.id)
                {
                    employee[i].name = emp.name;
                    employee[i].salary = emp.salary;
                    break; // to break the loop
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].id == id)
                {
                    employee.Remove(employee[i]);
                    break;
                }
            }
        }


        public List<Employee> List()
        {
            return employee;
        }


        public Employee ViewEmployee(int id)
        {
            Employee employee1 = new Employee();

            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].id == id)
                {
                    employee1 = employee[i];
                    break;
                }
            }
            return employee1;
        }

    }
}
