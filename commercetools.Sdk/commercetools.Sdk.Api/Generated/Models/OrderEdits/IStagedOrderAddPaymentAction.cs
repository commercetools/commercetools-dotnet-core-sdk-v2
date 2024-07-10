using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddPaymentAction))]
    public partial interface IStagedOrderAddPaymentAction : IStagedOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }

    }
}
