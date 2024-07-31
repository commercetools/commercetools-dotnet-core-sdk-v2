using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchNumberRangeExpression))]
    public partial interface IOrderSearchNumberRangeExpression : IOrderSearchQueryExpression
    {
        IOrderSearchNumberRangeValue Range { get; set; }

    }
}
