using Practice_EntityFramework.Core.Entities;

namespace Practice_EntityFramework.Service.Interface;

public interface IEmployee
{
    List<Employee> GetAllEmployees();
    void GetEmployeeById(int Id);
    void CreateEmployee(string name, string surname, int salary);
    List<Employee> SearchEmployeeByName(string search);
}
