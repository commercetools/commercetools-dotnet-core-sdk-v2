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

    public partial class ChangeShipmentStateChange : IChangeShipmentStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShipmentState PreviousValue { get; set; }

        public IShipmentState NextValue { get; set; }
        public ChangeShipmentStateChange()
        {
            this.Type = "ChangeShipmentStateChange";
        }
    }
}
