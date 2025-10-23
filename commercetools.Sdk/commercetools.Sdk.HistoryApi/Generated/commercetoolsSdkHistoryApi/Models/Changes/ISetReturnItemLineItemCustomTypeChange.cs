using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReturnItemLineItemCustomTypeChange))]
    public partial interface ISetReturnItemLineItemCustomTypeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string Variant { get; set; }

        ILocalizedString LineItem { get; set; }

        string LineItemId { get; set; }

        ICustomFields PreviousValue { get; set; }

        ICustomFields NextValue { get; set; }

    }
}
