using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class ProductProperty : BaseEntity
    {
        public string PropertyName { get; set; }

        public int? ProductID { get; set; }

        //Relational Properties
        public virtual Product Product { get; set; }
        public virtual List<ProductValue> ProductValues { get; set; }
    }
}
