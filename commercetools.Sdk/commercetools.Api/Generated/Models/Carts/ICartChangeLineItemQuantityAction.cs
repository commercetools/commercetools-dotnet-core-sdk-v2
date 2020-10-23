using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICartChangeLineItemQuantityAction : ICartUpdateAction
    {
        string LineItemId { get; set;}
        
        long Quantity { get; set;}
        
        IMoney ExternalPrice { get; set;}
        
        IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
    }
}
