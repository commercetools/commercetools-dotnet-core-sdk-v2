using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public class ItemState 
    {
        public double Quantity { get; set;}
        
        public StateReference State { get; set;}
    }
}
