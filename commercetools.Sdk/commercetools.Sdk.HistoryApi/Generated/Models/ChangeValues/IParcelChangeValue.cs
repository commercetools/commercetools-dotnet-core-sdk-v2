using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ParcelChangeValue))]
    public partial interface IParcelChangeValue
    {
        string Id { get; set; }

        string CreatedAt { get; set; }
    }
}
