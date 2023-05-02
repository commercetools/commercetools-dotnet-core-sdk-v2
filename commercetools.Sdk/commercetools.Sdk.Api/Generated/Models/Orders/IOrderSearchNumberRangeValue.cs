using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchNumberRangeValue))]
    public partial interface IOrderSearchNumberRangeValue : IOrderSearchQueryExpressionValue
    {
        decimal? Gte { get; set; }

        decimal? Lte { get; set; }

    }
}
