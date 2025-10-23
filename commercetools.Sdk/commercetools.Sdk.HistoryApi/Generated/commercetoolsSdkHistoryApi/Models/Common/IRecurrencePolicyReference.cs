using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.RecurrencePolicyReference))]
    public partial interface IRecurrencePolicyReference : IReference
    {
        new string Id { get; set; }

    }
}
