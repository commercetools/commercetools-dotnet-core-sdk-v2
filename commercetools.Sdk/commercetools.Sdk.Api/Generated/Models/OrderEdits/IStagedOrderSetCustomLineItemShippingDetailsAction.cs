using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsAction))]
    public interface IStagedOrderSetCustomLineItemShippingDetailsAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
