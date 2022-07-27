using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddShippingAddressIdChange : IAddShippingAddressIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<string> NextValue { get; set; }

        public List<string> PreviousValue { get; set; }

        public IAddress Address { get; set; }
        public AddShippingAddressIdChange()
        {
            this.Type = "AddShippingAddressIdChange";
        }
    }
}
