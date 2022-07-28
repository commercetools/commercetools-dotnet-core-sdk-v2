using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLineItemQuantityChange))]
    public partial interface IChangeLineItemQuantityChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString LineItem { get; set; }

        string LineItemId { get; set; }

        int NextValue { get; set; }

        int PreviousValue { get; set; }

    }
}
