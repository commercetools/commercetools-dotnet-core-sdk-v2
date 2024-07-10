using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderFromQuoteDraft : IOrderFromQuoteDraft
    {
        public IQuoteResourceIdentifier Quote { get; set; }

        public long Version { get; set; }

        public bool? QuoteStateToAccepted { get; set; }

        public string OrderNumber { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IShipmentState ShipmentState { get; set; }

        public IOrderState OrderState { get; set; }

        public IStateResourceIdentifier State { get; set; }
    }
}
