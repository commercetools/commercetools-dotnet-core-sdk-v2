using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetLineItemsChangeValue))]
    public partial interface IChangeTargetLineItemsChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set; }

        string Predicate { get; set; }

    }
}
