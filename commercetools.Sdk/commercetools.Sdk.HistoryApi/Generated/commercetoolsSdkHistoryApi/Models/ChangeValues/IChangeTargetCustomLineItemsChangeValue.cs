using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetCustomLineItemsChangeValue))]
    public partial interface IChangeTargetCustomLineItemsChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set; }

        string Predicate { get; set; }

    }
}
