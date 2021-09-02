using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddAddressChange : IAddAddressChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAddress NextValue { get; set; }

        public IAddress PreviousValue { get; set; }
        public AddAddressChange()
        {
            this.Type = "AddAddressChange";
        }
    }
}
