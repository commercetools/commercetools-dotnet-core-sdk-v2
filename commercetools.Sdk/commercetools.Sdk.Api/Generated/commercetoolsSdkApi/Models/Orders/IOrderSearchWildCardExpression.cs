using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchWildCardExpression))]
    public partial interface IOrderSearchWildCardExpression : IOrderSearchQueryExpression
    {
        IOrderSearchStringValue Wildcard { get; set; }

    }
}
