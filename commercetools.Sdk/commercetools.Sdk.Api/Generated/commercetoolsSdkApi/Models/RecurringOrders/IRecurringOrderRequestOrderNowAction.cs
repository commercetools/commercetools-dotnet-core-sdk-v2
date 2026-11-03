using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderRequestOrderNowAction))]
    public partial interface IRecurringOrderRequestOrderNowAction : IRecurringOrderUpdateAction
    {
        string Reason { get; set; }

    }
}
