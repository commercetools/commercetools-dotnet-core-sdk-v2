using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddShippingAddressIdChange : IAddShippingAddressIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<string> NextValue { get; set; }
        public IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }


        public IList<string> PreviousValue { get; set; }
        public IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IAddress Address { get; set; }
        public AddShippingAddressIdChange()
        {
            this.Type = "AddShippingAddressIdChange";
        }
    }
}
