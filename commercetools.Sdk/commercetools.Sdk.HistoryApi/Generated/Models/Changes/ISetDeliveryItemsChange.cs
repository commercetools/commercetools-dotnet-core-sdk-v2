using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryItemsChange))]
    public partial interface ISetDeliveryItemsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string DeliveryId { get; set; }

        IList<IDeliveryItem> NextValue { get; set; }
        IEnumerable<IDeliveryItem> NextValueEnumerable { set => NextValue = value.ToList(); }


        IList<IDeliveryItem> PreviousValue { get; set; }
        IEnumerable<IDeliveryItem> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


    }
}
