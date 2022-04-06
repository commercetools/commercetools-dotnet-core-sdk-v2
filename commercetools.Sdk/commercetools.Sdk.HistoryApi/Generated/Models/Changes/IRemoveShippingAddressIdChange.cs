using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveShippingAddressIdChange))]
    public partial interface IRemoveShippingAddressIdChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        List<string> NextValue { get; set; }

        List<string> PreviousValue { get; set; }

        IAddress Address { get; set; }
    }
}
