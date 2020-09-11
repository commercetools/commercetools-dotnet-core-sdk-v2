using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class ItemState 
    {
        public double Quantity { get; set;}
        
        public StateReference State { get; set;}
    }
}
