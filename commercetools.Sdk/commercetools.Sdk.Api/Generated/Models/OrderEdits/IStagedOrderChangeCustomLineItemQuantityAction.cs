using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemQuantityAction))]
    public partial interface IStagedOrderChangeCustomLineItemQuantityAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        double Quantity { get; set;}
    }
}
