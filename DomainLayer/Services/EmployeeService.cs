using DAL.Entities;
using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        IGenericRepository<Employee> employeeRepository;
        IDepartmentService departmentRepository;
        ILocationService locationRepository;
        public EmployeeService(IGenericRepository<Employee> IEmployeeRepository, IDepartmentService IDepartmentRepository, ILocationService ILocationRepository)
        {
            employeeRepository = IEmployeeRepository;
            departmentRepository = IDepartmentRepository;
            locationRepository = ILocationRepository;
        }

        public void CreateEmployee(EmployeeModel employee)
        {
            var data = new Employee() { EmployeeNo = employee.EmployeeNo, FullName = employee.FullName, LocationId = employee.LocationId, DepartmentId = employee.DepartmentId };
            employeeRepository.Insert(data);
        }

        public void DeleteEmployee(int id)
        {
            employeeRepository.Delete(id);
        }

        public Employee GetEmployeeById(int id)
        {
            return employeeRepository.GetById(id);
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            var listdata = employeeRepository.GetAll();
            var employeelist =new List<EmployeeModel>();
            foreach (var data in listdata)
            {
                var employee = new EmployeeModel();
                employee.Id = data.Id;
                employee.EmployeeNo = data.EmployeeNo;
                employee.FullName = data.FullName;
                employee.Location = new LocationModel();
                employee.LocationId = data.LocationId;
                employee.Location = locationRepository.GetLocationById(data.LocationId);
                employee.Department = new DepartmentModel();
                employee.DepartmentId = data.DepartmentId;
                employee.Department = departmentRepository.GetDepartmentByID(data.DepartmentId);
                employeelist.Add(employee);
            }
            return employeelist;
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            var data = new Employee() {Id=employee.Id, EmployeeNo = employee.EmployeeNo, FullName = employee.FullName, LocationId = employee.LocationId, DepartmentId = employee.DepartmentId };
            employeeRepository.Update(data);
        }
    }
}
