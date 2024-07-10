using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderPurchaseOrderNumberSetMessagePayload : IOrderPurchaseOrderNumberSetMessagePayload
    {
        public string Type { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public string OldPurchaseOrderNumber { get; set; }
        public OrderPurchaseOrderNumberSetMessagePayload()
        {
            this.Type = "OrderPurchaseOrderNumberSet";
        }
    }
}
