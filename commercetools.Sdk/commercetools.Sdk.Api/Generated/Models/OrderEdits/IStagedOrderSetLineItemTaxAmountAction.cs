using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction))]
    public partial interface IStagedOrderSetLineItemTaxAmountAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set;}
        
        IExternalTaxAmountDraft ExternalTaxAmount { get; set;}
    }
}
