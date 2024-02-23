using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
