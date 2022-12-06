using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderImportDraft : IOrderImportDraft
    {
        public string OrderNumber { get; set; }

        public string CustomerId { get; set; }

        public string CustomerEmail { get; set; }

        public IList<ILineItemImportDraft> LineItems { get; set; }
        public IEnumerable<ILineItemImportDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }


        public IList<ICustomLineItemImportDraft> CustomLineItems { get; set; }
        public IEnumerable<ICustomLineItemImportDraft> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }


        public IMoney TotalPrice { get; set; }

        public ITaxedPriceDraft TaxedPrice { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IBaseAddress BillingAddress { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public string Country { get; set; }

        public IOrderState OrderState { get; set; }

        public IStateReference State { get; set; }

        public IShipmentState ShipmentState { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IShippingInfoImportDraft ShippingInfo { get; set; }

        public IPaymentInfo PaymentInfo { get; set; }

        public DateTime? CompletedAt { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }

        public IList<IBaseAddress> ItemShippingAddresses { get; set; }
        public IEnumerable<IBaseAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }


        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        public IStoreResourceIdentifier Store { get; set; }

        public ICartOrigin Origin { get; set; }
    }
}
