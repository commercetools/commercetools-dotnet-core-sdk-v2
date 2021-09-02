using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddShippingAddressIdChange))]
    public partial interface IAddShippingAddressIdChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        List<string> NextValue { get; set; }

        List<string> PreviousValue { get; set; }

        IAddress Address { get; set; }
    }
}
