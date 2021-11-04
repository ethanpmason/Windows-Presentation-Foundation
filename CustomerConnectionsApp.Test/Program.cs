using CustomerConnectionsApp.Domain.Services;
using CustomerConnectionsApp.EntityFramework;
using CustomerConnectionsApp.EntityFramework.ViewModelServices;
using CustomerConnectionsApp.Models;
using System;
using System.Linq;

namespace CustomerConnectionsApp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<Customer> customerService = new GenericDataService<Customer>(new DataContext());

            //Console.WriteLine(customerService.Delete(2).Result);

            //Console.WriteLine(customerService.Update(2, new Customer() { strName="test2" }).Result);

            //Console.WriteLine(customerService.Get(2).Result);

            //Console.WriteLine(customerService.GetAll().Result.Count());

            //customerService.Create(new Customer { strName = "Test" }).Wait();

            Console.ReadLine();
        }
    }
}
