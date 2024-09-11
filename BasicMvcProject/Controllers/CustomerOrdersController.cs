using BasicMvcProject.Models;
using BasicMvcProject.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BasicMvcProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Canberk",
                LastName = "Doğan",
                Email = "candogan@patika.com"
            };

            var orders = new List<Order>();
            {
                orders.Add(new Order { Id = 1, Price = 123, ProductName = "babara", Quantity = 1 });
                orders.Add(new Order { Id = 2, Price = 456, ProductName = "Ratatuy",Quantity = 1 });
                
            }


            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders


            };

            return View(viewModel);
        }
    }
}
