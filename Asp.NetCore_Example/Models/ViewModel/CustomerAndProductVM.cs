using System.Collections.Generic;

namespace Asp.NetCore_Example.Models.ViewModel
{
    public class CustomerAndProductVM
    {
        public Product products { get; set; }
        public List<Customer> customers { get; set; }
        public string date { get; set; }
    }
}
