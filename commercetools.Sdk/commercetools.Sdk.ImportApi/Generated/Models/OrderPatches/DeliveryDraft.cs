using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.OrderPatches;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class DeliveryDraft : IDeliveryDraft
    {
        public List<IDeliveryItem> Items { get; set; }

        public IAddress Address { get; set; }

        public List<IDeliveryParcelDraft> Parcels { get; set; }
    }
}
