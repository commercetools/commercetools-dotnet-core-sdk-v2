using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.Delivery))]
    public partial interface IDelivery
    {
        string Id { get; set; }

        DateTime CreatedAt { get; set; }

        List<IDeliveryItem> Items { get; set; }

        List<IParcel> Parcels { get; set; }

        IAddress Address { get; set; }
    }
}
