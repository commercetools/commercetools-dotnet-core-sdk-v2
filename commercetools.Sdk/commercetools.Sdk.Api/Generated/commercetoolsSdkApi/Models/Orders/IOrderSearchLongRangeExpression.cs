using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchLongRangeExpression))]
    public partial interface IOrderSearchLongRangeExpression : IOrderSearchQueryExpression
    {
        IOrderSearchLongRangeValue Range { get; set; }

    }
}
