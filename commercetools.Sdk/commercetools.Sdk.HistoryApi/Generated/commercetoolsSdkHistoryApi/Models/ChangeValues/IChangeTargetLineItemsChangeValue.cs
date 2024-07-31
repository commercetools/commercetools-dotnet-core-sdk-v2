using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetLineItemsChangeValue))]
    public partial interface IChangeTargetLineItemsChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set; }

        string Predicate { get; set; }

    }
}
