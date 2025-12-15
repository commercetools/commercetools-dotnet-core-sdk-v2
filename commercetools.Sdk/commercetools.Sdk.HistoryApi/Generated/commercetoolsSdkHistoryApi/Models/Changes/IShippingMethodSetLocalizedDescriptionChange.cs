using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ShippingMethodSetLocalizedDescriptionChange))]
    public partial interface IShippingMethodSetLocalizedDescriptionChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ILocalizedString PreviousValue { get; set; }

        ILocalizedString NextValue { get; set; }

    }
}
