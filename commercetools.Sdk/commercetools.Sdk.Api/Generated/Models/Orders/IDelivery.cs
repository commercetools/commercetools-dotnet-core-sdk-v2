using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.Delivery))]
    public partial interface IDelivery
    {
        string Id { get; set; }

        DateTime CreatedAt { get; set; }

        List<IDeliveryItem> Items { get; set; }

        List<IParcel> Parcels { get; set; }

        IAddress Address { get; set; }
    }
}
