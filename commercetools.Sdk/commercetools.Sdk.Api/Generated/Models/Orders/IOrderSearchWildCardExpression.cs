using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchWildCardExpression))]
    public partial interface IOrderSearchWildCardExpression : IOrderSearchQueryExpression
    {
        IOrderSearchStringValue Wildcard { get; set; }

    }
}
