using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.Delivery))]
    public partial interface IDelivery
    {
        string Id { get; set; }

        DateTime CreatedAt { get; set; }

        IList<IDeliveryItem> Items { get; set; }

        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        IList<IParcel> Parcels { get; set; }

        IEnumerable<IParcel> ParcelsEnumerable { set => Parcels = value.ToList(); }

        IAddress Address { get; set; }

    }
}
