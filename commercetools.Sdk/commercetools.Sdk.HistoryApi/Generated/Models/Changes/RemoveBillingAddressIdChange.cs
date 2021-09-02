using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveBillingAddressIdChange : IRemoveBillingAddressIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<string> NextValue { get; set; }

        public List<string> PreviousValue { get; set; }

        public IAddress Address { get; set; }
        public RemoveBillingAddressIdChange()
        {
            this.Type = "RemoveBillingAddressIdChange";
        }
    }
}
