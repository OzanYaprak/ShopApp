using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
    public class ProductCategory
    {
        public int CategoryID { get; set; }
        public int ProductID { get; set; }


        //navigations
        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}
