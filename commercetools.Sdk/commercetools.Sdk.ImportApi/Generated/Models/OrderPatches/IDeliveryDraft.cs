using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.OrderPatches;
using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.DeliveryDraft))]
    public partial interface IDeliveryDraft
    {
        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        IAddress Address { get; set; }

        IList<IDeliveryParcelDraft> Parcels { get; set; }
        IEnumerable<IDeliveryParcelDraft> ParcelsEnumerable { set => Parcels = value.ToList(); }


    }
}
