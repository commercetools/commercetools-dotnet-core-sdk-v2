using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.Orders
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

        public ICustomFieldsDraft Custom { get; set; }
    }
}
