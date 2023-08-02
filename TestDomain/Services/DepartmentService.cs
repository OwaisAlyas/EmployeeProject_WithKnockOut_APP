using DAL.Entities;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class DepartmentService : IDepartmentService
    {
        IDepartmentRepository genericRepository;
        public DepartmentService(IDepartmentRepository iGenericRepository)
        {
            genericRepository = iGenericRepository;
        }
        public IEnumerable<DepartmentModel> GetDepartment()
        {
            var listdata = genericRepository.GetAll();
            var departmentlist = new List<DepartmentModel>();
            foreach (var data in listdata)
            {
                var department = new DepartmentModel();
                department.DepartmentId = data.DepartmentId;
                department.DepartmentName = data.DepartmentName;
                departmentlist.Add(department);
            }
            return departmentlist;
        }
        public DepartmentModel GetDepartmentByID(int id)
        {
            var data = genericRepository.GetById(id);
            var department = new DepartmentModel();
            department.DepartmentId = data.DepartmentId;
            department.DepartmentName = data.DepartmentName;
            return department;
        }
    }
}
