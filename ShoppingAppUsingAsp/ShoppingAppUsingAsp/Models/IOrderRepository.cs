﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAppUsingAsp.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}