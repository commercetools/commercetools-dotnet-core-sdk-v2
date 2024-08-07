using commercetools.Sdk.Api.Models.Types;
using System;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class ReturnItem : IReturnItem
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
    }
}
