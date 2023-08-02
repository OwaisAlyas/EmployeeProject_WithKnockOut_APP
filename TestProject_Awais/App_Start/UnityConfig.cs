using DAL.Repositories;
using Domain.Interfaces;
using Domain.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace TestProject_Awais
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IGenericRepository, GenericRepository>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IDepartmentService, DepartmentService>();
            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<ILocationService, LocationService>();
            container.RegisterType<ILocationRepository, LocationRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}