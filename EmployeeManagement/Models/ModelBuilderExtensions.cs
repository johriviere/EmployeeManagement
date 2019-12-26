using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                      new Employee { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@gmail.com" },
                      new Employee { Id = 2, Name = "John", Department = Dept.IT, Email = "john@gmail.com" },
                      new Employee { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@gmail.com" }
              );
        }
    }
}
