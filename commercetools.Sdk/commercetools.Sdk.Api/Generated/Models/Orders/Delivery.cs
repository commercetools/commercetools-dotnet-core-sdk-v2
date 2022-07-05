using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class Delivery : IDelivery
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<IDeliveryItem> Items { get; set; }

        public List<IParcel> Parcels { get; set; }

        public IAddress Address { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
