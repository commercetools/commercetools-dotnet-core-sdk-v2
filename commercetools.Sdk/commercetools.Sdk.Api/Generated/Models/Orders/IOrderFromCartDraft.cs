using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.States;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderFromCartDraft))]
    public partial interface IOrderFromCartDraft
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        string Id { get; set; }

        ICartResourceIdentifier Cart { get; set; }

        long Version { get; set; }

        string OrderNumber { get; set; }

        IPaymentState PaymentState { get; set; }

        IShipmentState ShipmentState { get; set; }

        IOrderState OrderState { get; set; }

        IStateResourceIdentifier State { get; set; }
    }
}
