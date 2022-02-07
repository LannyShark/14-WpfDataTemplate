using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_WpfDataTemplate
{
    public enum ProductTypes
    {
        Food,
        Tech
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ImageSource { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
