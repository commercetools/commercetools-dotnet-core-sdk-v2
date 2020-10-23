using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddPaymentAction))]
    public interface IStagedOrderAddPaymentAction : IStagedOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
