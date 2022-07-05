using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetTextLineItemCustomTypeChange : ISetTextLineItemCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITextLineItemValue TextLineItem { get; set; }

        public ICustomFields NextValue { get; set; }

        public ICustomFields PreviousValue { get; set; }
        public SetTextLineItemCustomTypeChange()
        {
            this.Type = "SetTextLineItemCustomTypeChange";
        }
    }
}
