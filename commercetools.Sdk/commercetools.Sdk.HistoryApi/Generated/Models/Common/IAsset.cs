using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Asset))]
    public partial interface IAsset
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        ICustomFields Custom { get; set; }

        string Key { get; set; }
    }
}
