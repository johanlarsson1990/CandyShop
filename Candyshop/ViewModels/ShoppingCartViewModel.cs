﻿using Candyshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candyshop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart  ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
        public decimal DiscountTotal { get; set; }
    }
}
