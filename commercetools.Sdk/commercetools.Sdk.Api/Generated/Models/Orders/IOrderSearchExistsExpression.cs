using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchExistsExpression))]
    public partial interface IOrderSearchExistsExpression : IOrderSearchQueryExpression
    {
        IOrderSearchQueryExpressionValue Exists { get; set; }

    }
}
