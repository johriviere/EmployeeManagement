using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>
            {
                new Employee {Id=1, Name="Mary", Department= Dept.HR, Email="mary@gmail.com"},
                new Employee {Id=2, Name="John", Department=Dept.IT, Email="john@gmail.com"},
                new Employee {Id=3, Name="Sam", Department=Dept.IT, Email="sam@gmail.com" }
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee Add(Employee employee)
        {
            // compute id
            employee.Id = _employees.Max(e => e.Id) + 1;
            // add to 'database' (the private list)
            _employees.Add(employee);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }

        public Employee Delete(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
                _employees.Remove(employee);
            return employee;
        }
    }
}
