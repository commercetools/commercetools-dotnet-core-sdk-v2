using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.Cart))]
    public partial interface ICart : IBaseResource
    {
        new string Id { get; set; }

        string Key { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string CustomerId { get; set; }

        string CustomerEmail { get; set; }

        string AnonymousId { get; set; }

        IBusinessUnitKeyReference BusinessUnit { get; set; }

        IStoreKeyReference Store { get; set; }

        IList<ILineItem> LineItems { get; set; }
        IEnumerable<ILineItem> LineItemsEnumerable { set => LineItems = value.ToList(); }


        IList<ICustomLineItem> CustomLineItems { get; set; }
        IEnumerable<ICustomLineItem> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }


        ITypedMoney TotalPrice { get; set; }

        ITaxedPrice TaxedPrice { get; set; }

        ITaxedPrice TaxedShippingPrice { get; set; }

        ICartState CartState { get; set; }

        IAddress ShippingAddress { get; set; }

        IAddress BillingAddress { get; set; }

        IShippingMode ShippingMode { get; set; }

        IList<IShipping> Shipping { get; set; }
        IEnumerable<IShipping> ShippingEnumerable { set => Shipping = value.ToList(); }


        IInventoryMode InventoryMode { get; set; }

        ITaxMode TaxMode { get; set; }

        IRoundingMode TaxRoundingMode { get; set; }

        ITaxCalculationMode TaxCalculationMode { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        string Country { get; set; }

        IShippingInfo ShippingInfo { get; set; }

        IList<IDiscountCodeInfo> DiscountCodes { get; set; }
        IEnumerable<IDiscountCodeInfo> DiscountCodesEnumerable { set => DiscountCodes = value.ToList(); }


        IList<IDirectDiscount> DirectDiscounts { get; set; }
        IEnumerable<IDirectDiscount> DirectDiscountsEnumerable { set => DirectDiscounts = value.ToList(); }


        ICustomFields Custom { get; set; }

        IPaymentInfo PaymentInfo { get; set; }

        string Locale { get; set; }

        int? DeleteDaysAfterLastModification { get; set; }

        IList<ICartDiscountReference> RefusedGifts { get; set; }
        IEnumerable<ICartDiscountReference> RefusedGiftsEnumerable { set => RefusedGifts = value.ToList(); }


        ICartOrigin Origin { get; set; }

        IShippingRateInput ShippingRateInput { get; set; }

        IList<IAddress> ItemShippingAddresses { get; set; }
        IEnumerable<IAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }


        long? TotalLineItemQuantity { get; set; }

    }
}
