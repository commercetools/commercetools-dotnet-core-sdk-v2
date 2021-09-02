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
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.DeliveryDraft))]
    public partial interface IDeliveryDraft
    {
        List<IDeliveryItem> Items { get; set; }

        IAddress Address { get; set; }

        List<IDeliveryParcelDraft> Parcels { get; set; }
    }
}
