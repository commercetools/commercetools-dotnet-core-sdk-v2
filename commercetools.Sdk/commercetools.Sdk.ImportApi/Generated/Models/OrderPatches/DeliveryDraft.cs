using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.OrderPatches;
using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class DeliveryDraft : IDeliveryDraft
    {
        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        public IAddress Address { get; set; }

        public IList<IDeliveryParcelDraft> Parcels { get; set; }
        public IEnumerable<IDeliveryParcelDraft> ParcelsEnumerable { set => Parcels = value.ToList(); }

    }
}
