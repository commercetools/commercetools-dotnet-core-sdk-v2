using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
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

        IStoreKeyReference Store { get; set; }

        List<ILineItem> LineItems { get; set; }

        List<ICustomLineItem> CustomLineItems { get; set; }

        ITypedMoney TotalPrice { get; set; }

        ITaxedPrice TaxedPrice { get; set; }

        ICartState CartState { get; set; }

        IAddress ShippingAddress { get; set; }

        IAddress BillingAddress { get; set; }

        IInventoryMode InventoryMode { get; set; }

        ITaxMode TaxMode { get; set; }

        IRoundingMode TaxRoundingMode { get; set; }

        ITaxCalculationMode TaxCalculationMode { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        string Country { get; set; }

        IShippingInfo ShippingInfo { get; set; }

        List<IDiscountCodeInfo> DiscountCodes { get; set; }

        ICustomFields Custom { get; set; }

        IPaymentInfo PaymentInfo { get; set; }

        string Locale { get; set; }

        int? DeleteDaysAfterLastModification { get; set; }

        List<ICartDiscountReference> RefusedGifts { get; set; }

        ICartOrigin Origin { get; set; }

        IShippingRateInput ShippingRateInput { get; set; }

        List<IAddress> ItemShippingAddresses { get; set; }

        long? TotalLineItemQuantity { get; set; }
    }
}
