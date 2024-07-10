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

    public partial class RemoveShippingAddressIdChange : IRemoveShippingAddressIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<string> PreviousValue { get; set; }
        public IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<string> NextValue { get; set; }
        public IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }


        public IAddress Address { get; set; }
        public RemoveShippingAddressIdChange()
        {
            this.Type = "RemoveShippingAddressIdChange";
        }
    }
}
