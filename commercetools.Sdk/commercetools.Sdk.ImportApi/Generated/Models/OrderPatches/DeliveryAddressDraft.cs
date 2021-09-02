using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class DeliveryAddressDraft : IDeliveryAddressDraft
    {
        public string DeliveryId { get; set; }

        public IAddress Address { get; set; }
    }
}
