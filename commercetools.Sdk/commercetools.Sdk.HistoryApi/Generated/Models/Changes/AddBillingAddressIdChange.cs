using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class AddBillingAddressIdChange : IAddBillingAddressIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<string> NextValue { get; set; }

        public List<string> PreviousValue { get; set; }

        public IAddress Address { get; set; }
        public AddBillingAddressIdChange()
        {
            this.Type = "AddBillingAddressIdChange";
        }
    }
}
