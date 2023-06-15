using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveCustomLineItemChange))]
    public partial interface IRemoveCustomLineItemChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomLineItem PreviousValue { get; set; }

        ICustomLineItem NextValue { get; set; }

    }
}
