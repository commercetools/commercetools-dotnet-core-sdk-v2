using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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

        string PurchaseOrderNumber { get; set; }

        IPaymentState PaymentState { get; set; }

        IShipmentState ShipmentState { get; set; }

        IOrderState OrderState { get; set; }

        IStateResourceIdentifier State { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
