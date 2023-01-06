using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSizeType { get; set; }
        public decimal ProductSize { get; set; }
        public bool ProductStatus { get; set; }
        public int ProductCount{ get; set; }
        public string ProductColor{ get; set; }
        public string ProductBrand{ get; set; }
        public Category Category { get; set; }
    }
}
