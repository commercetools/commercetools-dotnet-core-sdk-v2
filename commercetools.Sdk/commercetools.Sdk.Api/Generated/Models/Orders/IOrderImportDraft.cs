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
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderImportDraft))]
    public partial interface IOrderImportDraft
    {
        string OrderNumber { get; set; }

        string CustomerId { get; set; }

        string CustomerEmail { get; set; }

        IList<ILineItemImportDraft> LineItems { get; set; }
        IEnumerable<ILineItemImportDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }


        IList<ICustomLineItemImportDraft> CustomLineItems { get; set; }
        IEnumerable<ICustomLineItemImportDraft> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }


        IMoney TotalPrice { get; set; }

        ITaxedPriceDraft TaxedPrice { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IBaseAddress BillingAddress { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        string Country { get; set; }

        IOrderState OrderState { get; set; }

        IStateReference State { get; set; }

        IShipmentState ShipmentState { get; set; }

        IPaymentState PaymentState { get; set; }

        IShippingInfoImportDraft ShippingInfo { get; set; }

        IPaymentInfo PaymentInfo { get; set; }

        DateTime? CompletedAt { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IInventoryMode InventoryMode { get; set; }

        IRoundingMode TaxRoundingMode { get; set; }

        IList<IBaseAddress> ItemShippingAddresses { get; set; }
        IEnumerable<IBaseAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }


        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        IStoreResourceIdentifier Store { get; set; }

        ICartOrigin Origin { get; set; }

    }
}
