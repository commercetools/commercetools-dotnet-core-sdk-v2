using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Asset))]
    public partial interface IAsset
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        ICustomFields Custom { get; set; }

        string Key { get; set; }

    }
}
