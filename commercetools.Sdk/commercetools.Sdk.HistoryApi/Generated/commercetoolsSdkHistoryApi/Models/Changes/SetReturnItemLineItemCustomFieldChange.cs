using commercetools.Sdk.HistoryApi.Models.Common;
using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetReturnItemLineItemCustomFieldChange : ISetReturnItemLineItemCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string Variant { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string LineItemId { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }
        public SetReturnItemLineItemCustomFieldChange()
        {
            this.Type = "SetReturnItemLineItemCustomFieldChange";
        }
    }
}
