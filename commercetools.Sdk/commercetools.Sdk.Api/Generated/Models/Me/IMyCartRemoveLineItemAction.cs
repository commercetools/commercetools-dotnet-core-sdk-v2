using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartRemoveLineItemAction))]
    public interface IMyCartRemoveLineItemAction : IMyCartUpdateAction
    {
        string LineItemId { get; set;}
        
        double Quantity { get; set;}
        
        IMoney ExternalPrice { get; set;}
        
        IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        IItemShippingDetailsDraft ShippingDetailsToRemove { get; set;}
    }
}
