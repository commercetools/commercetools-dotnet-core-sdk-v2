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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchLongRangeValue))]
    public partial interface IOrderSearchLongRangeValue : IOrderSearchQueryExpressionValue
    {
        long? Gte { get; set; }

        long? Lte { get; set; }

    }
}
