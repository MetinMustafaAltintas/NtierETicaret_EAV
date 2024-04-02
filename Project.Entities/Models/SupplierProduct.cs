using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class SupplierProduct : BaseEntity
    {
        public int SupplierID { get; set; }
        public int ProductID { get; set; }

        // Relational Properties

        public virtual Supplier Supplier { get; set; }
        public virtual Product Product { get; set; }
    }
}