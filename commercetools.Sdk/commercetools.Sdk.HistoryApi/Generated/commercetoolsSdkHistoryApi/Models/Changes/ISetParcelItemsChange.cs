using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetParcelItemsChange))]
    public partial interface ISetParcelItemsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IDeliveryItem> PreviousValue { get; set; }

        IEnumerable<IDeliveryItem> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IDeliveryItem> NextValue { get; set; }

        IEnumerable<IDeliveryItem> NextValueEnumerable { set => NextValue = value.ToList(); }

        IParcelChangeValue Parcel { get; set; }

    }
}
