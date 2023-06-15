using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeCustomLineItemQuantityChange))]
    public partial interface IChangeCustomLineItemQuantityChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        int PreviousValue { get; set; }

        int NextValue { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

    }
}
