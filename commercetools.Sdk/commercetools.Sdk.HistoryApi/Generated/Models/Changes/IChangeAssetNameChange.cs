using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetNameChange))]
    public partial interface IChangeAssetNameChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ILocalizedString PreviousValue { get; set; }

        ILocalizedString NextValue { get; set; }

        IAssetChangeValue Asset { get; set; }

    }
}
