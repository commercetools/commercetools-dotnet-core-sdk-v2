using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveBillingAddressIdChange))]
    public partial interface IRemoveBillingAddressIdChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<string> NextValue { get; set; }
        IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }


        IList<string> PreviousValue { get; set; }
        IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IAddress Address { get; set; }

    }
}
