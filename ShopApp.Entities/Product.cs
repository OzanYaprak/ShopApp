using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImageURL { get; set; }
        public decimal ProductPrice { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
