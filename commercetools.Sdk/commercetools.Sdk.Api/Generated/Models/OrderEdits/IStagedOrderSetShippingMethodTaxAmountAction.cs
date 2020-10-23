using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxAmountAction))]
    public interface IStagedOrderSetShippingMethodTaxAmountAction : IStagedOrderUpdateAction
    {
        IExternalTaxAmountDraft ExternalTaxAmount { get; set;}
    }
}
