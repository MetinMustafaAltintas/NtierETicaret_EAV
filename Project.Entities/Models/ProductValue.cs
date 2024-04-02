using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class ProductValue : BaseEntity
    {
        public string ProductValueName { get; set; }
        public int ProductID { get; set; }
        public int ProductPropertyID { get; set; }


        //Relational Properties

        public virtual Product Product { get; set; }
        public virtual ProductProperty ProductProperty { get; set; }
    }
}