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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchFullTextValue))]
    public partial interface IOrderSearchFullTextValue : IOrderSearchQueryExpressionValue
    {
        string Value { get; set; }

        string Language { get; set; }

        IOrderSearchMatchType MustMatch { get; set; }

    }
}
