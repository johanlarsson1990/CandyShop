﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candyshop.Models
{
    public interface ICategoryRepositoty
    {
        IEnumerable<Category> GetAllCategories { get; }

    }
}
