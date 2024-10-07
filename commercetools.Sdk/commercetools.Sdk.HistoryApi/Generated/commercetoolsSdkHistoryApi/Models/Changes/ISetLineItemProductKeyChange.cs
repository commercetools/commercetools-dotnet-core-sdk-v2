using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductKeyChange))]
    public partial interface ISetLineItemProductKeyChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

        ILocalizedString LineItem { get; set; }

        string LineItemId { get; set; }

        string Variant { get; set; }

    }
}
