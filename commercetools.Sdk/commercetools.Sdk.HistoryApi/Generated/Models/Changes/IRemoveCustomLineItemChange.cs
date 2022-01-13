using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveCustomLineItemChange))]
    public partial interface IRemoveCustomLineItemChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomLineItem NextValue { get; set; }

        ICustomLineItem PreviousValue { get; set; }
    }
}
