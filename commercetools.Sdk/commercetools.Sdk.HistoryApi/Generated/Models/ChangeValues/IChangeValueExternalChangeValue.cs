using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue))]
    public partial interface IChangeValueExternalChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }
    }
}
