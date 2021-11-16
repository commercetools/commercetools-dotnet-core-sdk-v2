using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingMethodAction))]
    public partial interface IStagedOrderSetShippingMethodAction : IStagedOrderUpdateAction
    {
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
