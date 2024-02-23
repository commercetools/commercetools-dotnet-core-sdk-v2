using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchExistsExpression))]
    public partial interface IOrderSearchExistsExpression : IOrderSearchQueryExpression
    {
        IOrderSearchQueryExpressionValue Exists { get; set; }

    }
}
