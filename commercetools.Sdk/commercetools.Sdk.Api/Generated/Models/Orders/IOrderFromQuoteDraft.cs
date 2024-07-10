using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderFromQuoteDraft))]
    public partial interface IOrderFromQuoteDraft
    {
        IQuoteResourceIdentifier Quote { get; set; }

        long Version { get; set; }

        bool? QuoteStateToAccepted { get; set; }

        string OrderNumber { get; set; }

        IPaymentState PaymentState { get; set; }

        IShipmentState ShipmentState { get; set; }

        IOrderState OrderState { get; set; }

        IStateResourceIdentifier State { get; set; }

    }
}
