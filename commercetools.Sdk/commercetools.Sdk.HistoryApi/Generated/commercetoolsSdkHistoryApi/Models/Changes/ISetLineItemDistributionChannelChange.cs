using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDistributionChannelChange))]
    public partial interface ISetLineItemDistributionChannelChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReference PreviousValue { get; set; }

        IReference NextValue { get; set; }

        ILocalizedString LineItem { get; set; }

        string Variant { get; set; }

    }
}
