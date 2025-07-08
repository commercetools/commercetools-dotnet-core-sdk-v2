using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.CounterDraft))]
    public partial interface ICounterDraft : ISkipConfigurationDraft
    {
        int TotalToSkip { get; set; }

    }
}
