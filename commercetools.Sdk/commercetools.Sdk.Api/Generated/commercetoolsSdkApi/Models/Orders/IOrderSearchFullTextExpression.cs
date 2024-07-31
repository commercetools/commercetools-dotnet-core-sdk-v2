using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchFullTextExpression))]
    public partial interface IOrderSearchFullTextExpression : IOrderSearchQueryExpression
    {
        IOrderSearchFullTextValue FullText { get; set; }

    }
}
