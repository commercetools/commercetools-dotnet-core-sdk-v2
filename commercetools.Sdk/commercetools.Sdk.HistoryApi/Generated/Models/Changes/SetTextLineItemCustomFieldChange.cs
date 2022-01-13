using commercetools.HistoryApi.Models.ChangeValues;
using System;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetTextLineItemCustomFieldChange : ISetTextLineItemCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }

        public ITextLineItemValue TextLineItem { get; set; }

        public Object NextValue { get; set; }

        public Object PreviousValue { get; set; }
        public SetTextLineItemCustomFieldChange()
        {
            this.Type = "SetTextLineItemCustomFieldChange";
        }
    }
}
