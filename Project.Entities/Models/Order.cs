using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Order : BaseEntity
    {
        public string RequestAddress { get; set; }

        public int AppUserID { get; set; }
        public int ShipperID { get; set; }

        //Relational Properties

        public virtual List<OrderProduct> OrderProducts { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual Shipper Shipper { get; set; }
    }
}
