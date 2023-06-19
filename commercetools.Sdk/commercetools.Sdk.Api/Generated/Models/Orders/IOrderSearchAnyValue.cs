using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchAnyValue))]
    public partial interface IOrderSearchAnyValue : IOrderSearchQueryExpressionValue
    {
        Object Value { get; set; }

        string Language { get; set; }

        bool? CaseInsensitive { get; set; }

    }
}
