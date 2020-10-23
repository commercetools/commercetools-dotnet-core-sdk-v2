using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRemoveLineItemAction))]
    public interface ICartRemoveLineItemAction : ICartUpdateAction
    {
        string LineItemId { get; set;}
        
        long Quantity { get; set;}
        
        IMoney ExternalPrice { get; set;}
        
        IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        IItemShippingDetailsDraft ShippingDetailsToRemove { get; set;}
    }
}
