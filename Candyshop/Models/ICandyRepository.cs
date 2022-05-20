﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candyshop.Models
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy { get; }
        IEnumerable<Candy> GetCandyOnSale { get; }
        Candy GetCandyById(int candyId);
    }
}
