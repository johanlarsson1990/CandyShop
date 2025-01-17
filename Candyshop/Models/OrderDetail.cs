﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candyshop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int CandyId { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get
            {
                return (Price - Candy.SalesPrice) * Amount;
            } }
        public Order Order { get; set; }
        public List<OrderDetail> Details { get; set; }

    }
}
