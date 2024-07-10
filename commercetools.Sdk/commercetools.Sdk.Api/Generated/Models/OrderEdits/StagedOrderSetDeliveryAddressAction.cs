using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetDeliveryAddressAction : IStagedOrderSetDeliveryAddressAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }

        public IBaseAddress Address { get; set; }
        public StagedOrderSetDeliveryAddressAction()
        {
            this.Action = "setDeliveryAddress";
        }
    }
}
