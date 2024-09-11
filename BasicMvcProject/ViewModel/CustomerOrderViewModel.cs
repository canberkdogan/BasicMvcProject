using BasicMvcProject.Models;

namespace BasicMvcProject.ViewModel
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }

        public List<Order> Orders { get; set; }

    }
}
