using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.DeliveryChangeValue))]
    public partial interface IDeliveryChangeValue
    {
        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        IAddress Address { get; set; }

        IList<IParcel> Parcels { get; set; }
        IEnumerable<IParcel> ParcelsEnumerable { set => Parcels = value.ToList(); }


    }
}
