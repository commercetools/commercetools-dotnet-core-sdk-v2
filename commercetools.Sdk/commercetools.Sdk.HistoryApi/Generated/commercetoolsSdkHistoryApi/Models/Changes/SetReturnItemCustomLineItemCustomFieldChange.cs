using commercetools.Sdk.HistoryApi.Models.Common;
using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetReturnItemCustomLineItemCustomFieldChange : ISetReturnItemCustomLineItemCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }
        public SetReturnItemCustomLineItemCustomFieldChange()
        {
            this.Type = "SetReturnItemCustomLineItemCustomFieldChange";
        }
    }
}
