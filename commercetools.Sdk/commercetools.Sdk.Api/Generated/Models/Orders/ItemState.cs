using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class ItemState : IItemState
    {
        public double Quantity { get; set;}
        
        public IStateReference State { get; set;}
    }
}
