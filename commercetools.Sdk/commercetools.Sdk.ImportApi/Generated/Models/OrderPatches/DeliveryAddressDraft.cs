using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class DeliveryAddressDraft : IDeliveryAddressDraft
    {
        public string DeliveryId { get; set; }

        public IAddress Address { get; set; }
    }
}
