using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IStagedOrderSetShippingMethodTaxRateAction : IStagedOrderUpdateAction
    {
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
