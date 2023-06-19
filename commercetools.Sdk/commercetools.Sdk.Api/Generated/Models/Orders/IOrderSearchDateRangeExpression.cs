using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchDateRangeExpression))]
    public partial interface IOrderSearchDateRangeExpression : IOrderSearchQueryExpression
    {
        IOrderSearchDateRangeValue Range { get; set; }

    }
}
