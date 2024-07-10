using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetPurchaseOrderNumberAction))]
    public partial interface IStagedOrderSetPurchaseOrderNumberAction : IStagedOrderUpdateAction
    {
        string PurchaseOrderNumber { get; set; }

    }
}
