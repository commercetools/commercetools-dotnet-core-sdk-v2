using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ValidFromAndUntilValue))]
    public partial interface IValidFromAndUntilValue
    {
        string ValidFrom { get; set; }

        string ValidUntil { get; set; }
    }
}
