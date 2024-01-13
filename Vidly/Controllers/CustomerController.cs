using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public ViewResult Index()
        {

            //Retrieve customers from db 

            //With customers 
            //var customers = new List<Customer> {
            //    new Customer { Id = 1, Name = "John Smith" },
            //    new Customer { Id = 2, Name = "Mary Williams" }
            //};

            //Without customers 
            var customers = new List<Customer>(); 

            var customerVM = new CustomersViewModel { Customers = new List <Customer>()};
            customerVM.Customers = customers; 

            return View(customerVM);
        }

        public ViewResult Details(int id) {

            //Retrieve customers from db 

            var customers = new List<Customer> {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };




            var targetCustomer = customers.Where(customer => customer.Id == id).FirstOrDefault();

            var targetCustomerVM = new CustomerViewModel { Customer = targetCustomer };  
            return View(targetCustomerVM);
        }

    }
}
