using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetMinDaysBetweenOrdersAction))]
    public partial interface IRecurrencePolicySetMinDaysBetweenOrdersAction : IRecurrencePolicyUpdateAction
    {
        int? MinDaysBetweenOrders { get; set; }

    }
}
