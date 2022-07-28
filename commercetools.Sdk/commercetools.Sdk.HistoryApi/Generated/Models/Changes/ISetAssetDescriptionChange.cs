using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetDescriptionChange))]
    public partial interface ISetAssetDescriptionChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAssetChangeValue Asset { get; set; }

        ILocalizedString NextValue { get; set; }

        ILocalizedString PreviousValue { get; set; }

    }
}
