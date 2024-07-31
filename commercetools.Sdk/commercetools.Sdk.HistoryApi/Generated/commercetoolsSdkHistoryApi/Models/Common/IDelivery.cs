using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Delivery))]
    public partial interface IDelivery
    {
        string Id { get; set; }

        string CreatedAt { get; set; }

        IList<IDeliveryItem> Items { get; set; }

        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        IList<IParcel> Parcels { get; set; }

        IEnumerable<IParcel> ParcelsEnumerable { set => Parcels = value.ToList(); }

        IAddress Address { get; set; }

        ICustomFields Custom { get; set; }

    }
}
