using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchQueryExpressionValue))]
    public partial interface IOrderSearchQueryExpressionValue
    {
        string Field { get; set; }

        int? Boost { get; set; }

        string CustomType { get; set; }

    }
}
