﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodavnica.Models
{
    public interface IOrders
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
