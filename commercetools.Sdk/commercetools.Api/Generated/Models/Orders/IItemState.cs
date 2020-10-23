using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IItemState 
    {
        double Quantity { get; set;}
        
        IStateReference State { get; set;}
    }
}
