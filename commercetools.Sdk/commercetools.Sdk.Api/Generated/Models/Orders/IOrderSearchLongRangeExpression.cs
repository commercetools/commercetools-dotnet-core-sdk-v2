using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchLongRangeExpression))]
    public partial interface IOrderSearchLongRangeExpression : IOrderSearchQueryExpression
    {
        IOrderSearchLongRangeValue Range { get; set; }

    }
}
