using Microsoft.EntityFrameworkCore;
using Practice_EntityFramework.Core.Entities;
using Practice_EntityFramework.DataAccess;
using Practice_EntityFramework.Exceptions;
using Practice_EntityFramework.Service.Interface;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Practice_EntityFramework.Service.Implemeatation;

public class EmployeeService : IEmployee
{


    public async void CreateEmployee(string name, string surname, int salary)
    {
        AppDbContext context = new();
        Employee emp = new()
        {
            Name = name,
            Surname = surname,
            Salary = salary
        };
        await context.Employees.AddAsync(emp);
        context.SaveChanges();
        //await context.SaveChangesAsync();
    }



    public List<Employee> GetAllEmployees()
    {
        AppDbContext context = new AppDbContext();
        var query = from emp in context.Employees
                    select emp;
        return query.ToList();
    }

    public void GetEmployeeById(int Id)
    {
        AppDbContext context = new();
        var query = context.Employees.Where(emp => emp.Id == Id).FirstOrDefault();
        //query.ToList();
        if (query == null)
        {
            throw new NotFoundException("data not found");
        }
        else
        {
            Console.WriteLine($"Id: {query.Id}\n" +
                    $"Name: {query.Name}\n" +
                    $"Surname: {query.Surname}\n" +
                    $"Salary: {query.Salary}");
        }
    }

    public List<Employee> SearchEmployeeByName(string search)
    {
        //throw new NotImplementedException();
        AppDbContext context = new AppDbContext();
        List<Employee> searchName = new List<Employee>();
        //var query = context.Employees.Where(emp );
        var query = from emp in context.Employees
                    where emp.Name.Contains($"{search}")
                    select emp;
        //searchName.Add((Employee)query);
        if (query == null)
        {
            throw new NotFoundException("data not found");
        }
        return query.ToList();
    }
}
