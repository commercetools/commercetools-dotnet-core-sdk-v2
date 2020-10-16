using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Orders
{
    public partial class ItemState 
    {
        public double Quantity { get; set;}
        
        public StateReference State { get; set;}
    }
}
