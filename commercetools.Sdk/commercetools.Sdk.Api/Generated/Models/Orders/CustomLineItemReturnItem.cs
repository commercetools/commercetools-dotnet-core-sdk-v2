using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class CustomLineItemReturnItem : ICustomLineItemReturnItem
    {
        public string Id { get; set; }

        public string Key { get; set; }

        public long Quantity { get; set; }

        public string Type { get; set; }

        public string Comment { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }

        public IReturnPaymentState PaymentState { get; set; }

        public ICustomFields Custom { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CustomLineItemId { get; set; }
        public CustomLineItemReturnItem()
        {
            this.Type = "CustomLineItemReturnItem";
        }
    }
}
