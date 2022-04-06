using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ValidFromAndUntilValue))]
    public partial interface IValidFromAndUntilValue
    {
        string ValidFrom { get; set; }

        string ValidUntil { get; set; }
    }
}
