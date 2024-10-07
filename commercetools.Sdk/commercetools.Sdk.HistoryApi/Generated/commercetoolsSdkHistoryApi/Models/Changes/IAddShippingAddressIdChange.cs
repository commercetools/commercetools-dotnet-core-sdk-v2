using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddShippingAddressIdChange))]
    public partial interface IAddShippingAddressIdChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<string> PreviousValue { get; set; }

        IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<string> NextValue { get; set; }

        IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }

        IAddress Address { get; set; }

    }
}
