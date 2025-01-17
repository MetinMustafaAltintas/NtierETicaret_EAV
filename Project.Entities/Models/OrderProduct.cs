﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class OrderProduct : BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        //Relational Properties

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

