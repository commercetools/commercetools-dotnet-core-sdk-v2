using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchPrefixExpression))]
    public partial interface IOrderSearchPrefixExpression : IOrderSearchQueryExpression
    {
        IOrderSearchStringValue Prefix { get; set; }

    }
}
