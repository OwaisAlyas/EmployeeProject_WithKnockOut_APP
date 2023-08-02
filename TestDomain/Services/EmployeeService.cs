using DAL.Entities;
using DAL.Repositories;
using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        //Repository
        IEmployeeRepository employeeRepository;
        
        public EmployeeService(IEmployeeRepository IEmployeeRepository)
        {
            employeeRepository = IEmployeeRepository;
        }

        public void CreateEmployee(EmployeeModel employee)
        {
            var data = new Employee() { EmployeeNo = employee.EmployeeNo, FullName = employee.FullName, LocationId = employee.LocationId.Value, DepartmentId = employee.DepartmentId.Value };
            employeeRepository.Insert(data);
        }

        public void DeleteEmployee(int id)
        {
            employeeRepository.Delete(id);
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            var data = employeeRepository.GetById(id);
            var employee = new EmployeeModel();
            employee.Id = data.Id;
            employee.EmployeeNo = data.EmployeeNo;
            employee.FullName = data.FullName;
            employee.Location = new LocationModel();
            employee.LocationId = data.LocationId;
            employee.Location = new LocationModel() { LocationId = data.Location.LocationId, LocationName = data.Location.LocationName };// locationService.GetLocationById(data.LocationId);
            employee.Department = new DepartmentModel();
            employee.DepartmentId = data.DepartmentId;
            employee.Department = new DepartmentModel() { DepartmentId = data.Department.DepartmentId, DepartmentName = data.Department.DepartmentName };// departmentService.GetDepartmentByID(data.DepartmentId);

            return employee;
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            var listdata = employeeRepository.GetAll();
            var employeelist = new List<EmployeeModel>();
            foreach (var data in listdata)
            {
                var employee = new EmployeeModel();
                employee.Id = data.Id;
                employee.EmployeeNo = data.EmployeeNo;
                employee.FullName = data.FullName;
                employee.Location = new LocationModel();
                employee.LocationId = data.LocationId;
                employee.Location = new LocationModel() { LocationId = data.Location.LocationId, LocationName = data.Location.LocationName };// locationService.GetLocationById(data.LocationId);
                employee.Department = new DepartmentModel();
                employee.DepartmentId = data.DepartmentId;
                employee.Department = new DepartmentModel() { DepartmentId = data.Department.DepartmentId, DepartmentName = data.Department.DepartmentName };// departmentService.GetDepartmentByID(data.DepartmentId);
                employeelist.Add(employee);
            }
            return employeelist;
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            var data = new Employee() { Id = employee.Id.Value, EmployeeNo = employee.EmployeeNo, FullName = employee.FullName, LocationId = employee.LocationId.Value, DepartmentId = employee.DepartmentId.Value };
            employeeRepository.Update(data);
        }
    }
}
