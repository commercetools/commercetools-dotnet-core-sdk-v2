using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemCustomTypeChange))]
    public partial interface ISetCustomLineItemCustomTypeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

        ICustomFields NextValue { get; set; }

        ICustomFields PreviousValue { get; set; }
    }
}
