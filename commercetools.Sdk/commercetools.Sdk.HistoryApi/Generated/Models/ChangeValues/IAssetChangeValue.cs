using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.AssetChangeValue))]
    public partial interface IAssetChangeValue
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

    }
}
