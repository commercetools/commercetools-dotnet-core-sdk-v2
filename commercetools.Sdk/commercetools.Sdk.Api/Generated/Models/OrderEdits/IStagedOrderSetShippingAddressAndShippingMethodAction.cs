using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodAction))]
    public interface IStagedOrderSetShippingAddressAndShippingMethodAction : IStagedOrderUpdateAction
    {
        IAddress Address { get; set;}
        
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
