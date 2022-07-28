using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddTextLineItemChange))]
    public partial interface IAddTextLineItemChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITextLineItem NextValue { get; set; }

    }
}
