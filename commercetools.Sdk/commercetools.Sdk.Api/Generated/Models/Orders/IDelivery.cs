using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.Delivery))]
    public partial interface IDelivery
    {
        string Id { get; set; }

        DateTime CreatedAt { get; set; }

        List<IDeliveryItem> Items { get; set; }

        List<IParcel> Parcels { get; set; }

        IAddress Address { get; set; }

        ICustomFields Custom { get; set; }
    }
}
