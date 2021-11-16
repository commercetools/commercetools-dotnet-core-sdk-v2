using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue))]
    public partial interface IChangeValueExternalChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }
    }
}
