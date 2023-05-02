using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchDateRangeValue))]
    public partial interface IOrderSearchDateRangeValue : IOrderSearchQueryExpressionValue
    {
        DateTime? Gte { get; set; }

        DateTime? Lte { get; set; }

    }
}
