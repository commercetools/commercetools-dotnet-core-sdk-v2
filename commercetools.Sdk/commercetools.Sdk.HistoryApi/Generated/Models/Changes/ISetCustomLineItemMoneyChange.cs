using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemMoneyChange))]
    public partial interface ISetCustomLineItemMoneyChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IMoney PreviousValue { get; set; }

        IMoney NextValue { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

    }
}
