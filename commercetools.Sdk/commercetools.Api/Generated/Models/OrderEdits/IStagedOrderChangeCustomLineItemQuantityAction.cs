using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IStagedOrderChangeCustomLineItemQuantityAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        double Quantity { get; set;}
    }
}
