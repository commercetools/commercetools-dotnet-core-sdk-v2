using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchLongRangeValue))]
    public partial interface IOrderSearchLongRangeValue : IOrderSearchQueryExpressionValue
    {
        long? Gte { get; set; }

        long? Lte { get; set; }

    }
}
