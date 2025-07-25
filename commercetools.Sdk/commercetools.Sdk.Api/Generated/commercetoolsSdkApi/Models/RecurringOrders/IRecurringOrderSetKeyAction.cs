using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetKeyAction))]
    public partial interface IRecurringOrderSetKeyAction : IRecurringOrderUpdateAction
    {
        string Key { get; set; }

    }
}
