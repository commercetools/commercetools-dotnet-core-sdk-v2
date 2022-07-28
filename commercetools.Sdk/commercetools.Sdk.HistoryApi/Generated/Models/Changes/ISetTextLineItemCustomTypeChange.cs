using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomTypeChange))]
    public partial interface ISetTextLineItemCustomTypeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITextLineItemValue TextLineItem { get; set; }

        ICustomFields NextValue { get; set; }

        ICustomFields PreviousValue { get; set; }

    }
}
