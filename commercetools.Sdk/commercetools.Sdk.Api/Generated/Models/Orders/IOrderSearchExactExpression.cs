using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchExactExpression))]
    public partial interface IOrderSearchExactExpression : IOrderSearchQueryExpression
    {
        IOrderSearchAnyValue Exact { get; set; }

    }
}
