using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderRemovePaymentAction))]
    public partial interface IOrderRemovePaymentAction : IOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }

    }
}
