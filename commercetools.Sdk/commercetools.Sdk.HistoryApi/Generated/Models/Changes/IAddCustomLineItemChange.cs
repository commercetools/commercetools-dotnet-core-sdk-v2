using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddCustomLineItemChange))]
    public partial interface IAddCustomLineItemChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomLineItem NextValue { get; set; }

        ICustomLineItem PreviousValue { get; set; }
    }
}
