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

    public partial class AddCustomLineItemChange : IAddCustomLineItemChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomLineItem PreviousValue { get; set; }

        public ICustomLineItem NextValue { get; set; }
        public AddCustomLineItemChange()
        {
            this.Type = "AddCustomLineItemChange";
        }
    }
}
