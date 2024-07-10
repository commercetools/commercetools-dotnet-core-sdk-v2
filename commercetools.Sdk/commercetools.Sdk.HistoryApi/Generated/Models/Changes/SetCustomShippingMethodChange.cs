using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetCustomShippingMethodChange : ISetCustomShippingMethodChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomShippingMethodChangeValue PreviousValue { get; set; }

        public ICustomShippingMethodChangeValue NextValue { get; set; }
        public SetCustomShippingMethodChange()
        {
            this.Type = "SetCustomShippingMethodChange";
        }
    }
}
