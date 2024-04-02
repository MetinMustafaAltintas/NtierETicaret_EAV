using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class OrderProductConfiguration:BaseConfiguration<OrderProduct>
    {
        public OrderProductConfiguration()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ProductID,
                x.OrderID
            });
        }
    }
}
