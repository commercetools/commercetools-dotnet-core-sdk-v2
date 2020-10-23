using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICartSetShippingMethodAction : ICartUpdateAction
    {
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
