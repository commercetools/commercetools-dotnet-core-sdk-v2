using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderFromCartDraft : IOrderFromCartDraft
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public string Id { get; set; }

        public ICartResourceIdentifier Cart { get; set; }

        public long Version { get; set; }

        public string OrderNumber { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IShipmentState ShipmentState { get; set; }

        public IOrderState OrderState { get; set; }

        public IStateResourceIdentifier State { get; set; }
    }
}
