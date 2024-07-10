using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetOrderLineItemCustomTypeChange : ISetOrderLineItemCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string Variant { get; set; }
        public SetOrderLineItemCustomTypeChange()
        {
            this.Type = "SetOrderLineItemCustomTypeChange";
        }
    }
}
