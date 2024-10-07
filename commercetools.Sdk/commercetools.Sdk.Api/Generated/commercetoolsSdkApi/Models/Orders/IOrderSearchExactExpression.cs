using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchExactExpression))]
    public partial interface IOrderSearchExactExpression : IOrderSearchQueryExpression
    {
        IOrderSearchAnyValue Exact { get; set; }

    }
}
