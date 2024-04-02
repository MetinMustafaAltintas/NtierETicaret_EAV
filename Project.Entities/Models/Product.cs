using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public int CategoryID { get; set; }

        //Relational Properties

        public virtual List<SupplierProduct> SupplierProducts { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<OrderProduct> OrderProducts { get; set; }

        public virtual List<ProductValue> ProductValues { get; set; }

        public virtual List<ProductProperty> ProductProperties { get; set; }
    }
}

