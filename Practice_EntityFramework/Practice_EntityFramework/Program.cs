using Practice_EntityFramework.Core.Entities;
using Practice_EntityFramework.DataAccess;
using Practice_EntityFramework.Service.Implemeatation;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

EmployeeService EmployeeService = new EmployeeService();
//EmployeeService.CreateEmployee("Afer", "Rehimov", 1000);
//EmployeeService.CreateEmployee("Amil", "Aliosmanov", 1350);
//EmployeeService.CreateEmployee("Resul", "Remixanov", 3455);


//EmployeeService.GetEmployeeById(2);


//foreach (var item in EmployeeService.SearchEmployeeByName("a"))
//{
//    Console.WriteLine($"Id: {item.Id}\n" +
//                    $"Name: {item.Name}\n" +
//                    $"Surname: {item.Surname}\n" +
//                    $"Salary: {item.Salary}\n");
//}


foreach (var item in EmployeeService.GetAllEmployees())
{
    Console.WriteLine($"Id: {item.Id}\n" +
                    $"Name: {item.Name}\n" +
                    $"Surname: {item.Surname}\n" +
                    $"Salary: {item.Salary}\n");
}