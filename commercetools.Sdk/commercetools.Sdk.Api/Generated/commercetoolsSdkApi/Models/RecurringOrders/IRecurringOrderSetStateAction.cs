using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStateAction))]
    public partial interface IRecurringOrderSetStateAction : IRecurringOrderUpdateAction
    {
        IRecurringOrderStateDraft RecurringOrderState { get; set; }

    }
}
