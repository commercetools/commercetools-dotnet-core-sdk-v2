using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Messages.MessagePayload))]
    [SubTypeDiscriminator("CategoryCreated", typeof(commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessagePayload))]
    [SubTypeDiscriminator("CategorySlugChanged", typeof(commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessagePayload))]
    [SubTypeDiscriminator("CustomerAddressAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessagePayload))]
    [SubTypeDiscriminator("CustomerAddressChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessagePayload))]
    [SubTypeDiscriminator("CustomerAddressRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessagePayload))]
    [SubTypeDiscriminator("CustomerCompanyNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessagePayload))]
    [SubTypeDiscriminator("CustomerCreated", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessagePayload))]
    [SubTypeDiscriminator("CustomerDateOfBirthSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload))]
    [SubTypeDiscriminator("CustomerDeleted", typeof(commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessagePayload))]
    [SubTypeDiscriminator("CustomerEmailChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessagePayload))]
    [SubTypeDiscriminator("CustomerEmailVerified", typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessagePayload))]
    [SubTypeDiscriminator("CustomerFirstNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessagePayload))]
    [SubTypeDiscriminator("CustomerGroupSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessagePayload))]
    [SubTypeDiscriminator("CustomerLastNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessagePayload))]
    [SubTypeDiscriminator("CustomerPasswordUpdated", typeof(commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessagePayload))]
    [SubTypeDiscriminator("CustomerTitleSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessagePayload))]
    [SubTypeDiscriminator("CustomLineItemStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessagePayload))]
    [SubTypeDiscriminator("DeliveryAdded", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessagePayload))]
    [SubTypeDiscriminator("DeliveryAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessagePayload))]
    [SubTypeDiscriminator("DeliveryItemsUpdated", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessagePayload))]
    [SubTypeDiscriminator("DeliveryRemoved", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessagePayload))]
    [SubTypeDiscriminator("InventoryEntryCreated", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessagePayload))]
    [SubTypeDiscriminator("InventoryEntryDeleted", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessagePayload))]
    [SubTypeDiscriminator("InventoryEntryQuantitySet", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessagePayload))]
    [SubTypeDiscriminator("LineItemStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessagePayload))]
    [SubTypeDiscriminator("OrderBillingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessagePayload))]
    [SubTypeDiscriminator("OrderCreated", typeof(commercetools.Sdk.Api.Models.Messages.OrderCreatedMessagePayload))]
    [SubTypeDiscriminator("OrderCustomerEmailSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessagePayload))]
    [SubTypeDiscriminator("OrderCustomerGroupSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessagePayload))]
    [SubTypeDiscriminator("OrderCustomerSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessagePayload))]
    [SubTypeDiscriminator("OrderCustomLineItemAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessagePayload))]
    [SubTypeDiscriminator("OrderCustomLineItemDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessagePayload))]
    [SubTypeDiscriminator("OrderCustomLineItemQuantityChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessagePayload))]
    [SubTypeDiscriminator("OrderCustomLineItemRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessagePayload))]
    [SubTypeDiscriminator("OrderDeleted", typeof(commercetools.Sdk.Api.Models.Messages.OrderDeletedMessagePayload))]
    [SubTypeDiscriminator("OrderDiscountCodeAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessagePayload))]
    [SubTypeDiscriminator("OrderDiscountCodeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessagePayload))]
    [SubTypeDiscriminator("OrderDiscountCodeStateSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessagePayload))]
    [SubTypeDiscriminator("OrderEditApplied", typeof(commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessagePayload))]
    [SubTypeDiscriminator("OrderImported", typeof(commercetools.Sdk.Api.Models.Messages.OrderImportedMessagePayload))]
    [SubTypeDiscriminator("OrderLineItemAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessagePayload))]
    [SubTypeDiscriminator("OrderLineItemDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessagePayload))]
    [SubTypeDiscriminator("OrderLineItemDistributionChannelSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessagePayload))]
    [SubTypeDiscriminator("OrderLineItemRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessagePayload))]
    [SubTypeDiscriminator("OrderPaymentAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessagePayload))]
    [SubTypeDiscriminator("OrderPaymentStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessagePayload))]
    [SubTypeDiscriminator("OrderReturnShipmentStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessagePayload))]
    [SubTypeDiscriminator("OrderShipmentStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessagePayload))]
    [SubTypeDiscriminator("OrderShippingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessagePayload))]
    [SubTypeDiscriminator("OrderShippingInfoSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessagePayload))]
    [SubTypeDiscriminator("OrderShippingRateInputSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessagePayload))]
    [SubTypeDiscriminator("OrderStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessagePayload))]
    [SubTypeDiscriminator("OrderStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.OrderStateTransitionMessagePayload))]
    [SubTypeDiscriminator("OrderStoreSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessagePayload))]
    [SubTypeDiscriminator("ParcelAddedToDelivery", typeof(commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessagePayload))]
    [SubTypeDiscriminator("ParcelItemsUpdated", typeof(commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessagePayload))]
    [SubTypeDiscriminator("ParcelMeasurementsUpdated", typeof(commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessagePayload))]
    [SubTypeDiscriminator("ParcelRemovedFromDelivery", typeof(commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessagePayload))]
    [SubTypeDiscriminator("ParcelTrackingDataUpdated", typeof(commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessagePayload))]
    [SubTypeDiscriminator("PaymentCreated", typeof(commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessagePayload))]
    [SubTypeDiscriminator("PaymentInteractionAdded", typeof(commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessagePayload))]
    [SubTypeDiscriminator("PaymentStatusInterfaceCodeSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload))]
    [SubTypeDiscriminator("PaymentStatusStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessagePayload))]
    [SubTypeDiscriminator("PaymentTransactionAdded", typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessagePayload))]
    [SubTypeDiscriminator("PaymentTransactionStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessagePayload))]
    [SubTypeDiscriminator("ProductAddedToCategory", typeof(commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessagePayload))]
    [SubTypeDiscriminator("ProductCreated", typeof(commercetools.Sdk.Api.Models.Messages.ProductCreatedMessagePayload))]
    [SubTypeDiscriminator("ProductDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductDeletedMessagePayload))]
    [SubTypeDiscriminator("ProductImageAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessagePayload))]
    [SubTypeDiscriminator("ProductPriceDiscountsSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessagePayload))]
    [SubTypeDiscriminator("ProductPriceExternalDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessagePayload))]
    [SubTypeDiscriminator("ProductPublished", typeof(commercetools.Sdk.Api.Models.Messages.ProductPublishedMessagePayload))]
    [SubTypeDiscriminator("ProductRemovedFromCategory", typeof(commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessagePayload))]
    [SubTypeDiscriminator("ProductRevertedStagedChanges", typeof(commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessagePayload))]
    [SubTypeDiscriminator("ProductSelectionCreated", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessagePayload))]
    [SubTypeDiscriminator("ProductSelectionDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessagePayload))]
    [SubTypeDiscriminator("ProductSelectionProductAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessagePayload))]
    [SubTypeDiscriminator("ProductSelectionProductRemoved", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessagePayload))]
    [SubTypeDiscriminator("ProductSelectionVariantSelectionChanged", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessagePayload))]
    [SubTypeDiscriminator("ProductSlugChanged", typeof(commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessagePayload))]
    [SubTypeDiscriminator("ProductStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessagePayload))]
    [SubTypeDiscriminator("ProductUnpublished", typeof(commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessagePayload))]
    [SubTypeDiscriminator("ProductVariantAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessagePayload))]
    [SubTypeDiscriminator("ProductVariantDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessagePayload))]
    [SubTypeDiscriminator("QuoteCreated", typeof(commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessagePayload))]
    [SubTypeDiscriminator("QuoteDeleted", typeof(commercetools.Sdk.Api.Models.Messages.QuoteDeletedMessagePayload))]
    [SubTypeDiscriminator("QuoteRequestCreated", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessagePayload))]
    [SubTypeDiscriminator("QuoteRequestDeleted", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestDeletedMessagePayload))]
    [SubTypeDiscriminator("QuoteRequestStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessagePayload))]
    [SubTypeDiscriminator("QuoteRequestStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessagePayload))]
    [SubTypeDiscriminator("QuoteStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessagePayload))]
    [SubTypeDiscriminator("QuoteStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessagePayload))]
    [SubTypeDiscriminator("ReturnInfoAdded", typeof(commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessagePayload))]
    [SubTypeDiscriminator("ReturnInfoSet", typeof(commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessagePayload))]
    [SubTypeDiscriminator("ReviewCreated", typeof(commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessagePayload))]
    [SubTypeDiscriminator("ReviewRatingSet", typeof(commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessagePayload))]
    [SubTypeDiscriminator("ReviewStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessagePayload))]
    [SubTypeDiscriminator("ShoppingListStoreSet", typeof(commercetools.Sdk.Api.Models.Messages.ShoppingListStoreSetMessagePayload))]
    [SubTypeDiscriminator("StagedQuoteCreated", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessagePayload))]
    [SubTypeDiscriminator("StagedQuoteDeleted", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteDeletedMessagePayload))]
    [SubTypeDiscriminator("StagedQuoteSellerCommentSet", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessagePayload))]
    [SubTypeDiscriminator("StagedQuoteStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessagePayload))]
    [SubTypeDiscriminator("StagedQuoteStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessagePayload))]
    [SubTypeDiscriminator("StagedQuoteValidToSet", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessagePayload))]
    [SubTypeDiscriminator("StandalonePriceCreated", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessagePayload))]
    [SubTypeDiscriminator("StandalonePriceDeleted", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessagePayload))]
    [SubTypeDiscriminator("StandalonePriceDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessagePayload))]
    [SubTypeDiscriminator("StandalonePriceExternalDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessagePayload))]
    [SubTypeDiscriminator("StandalonePriceStagedChangesApplied", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessagePayload))]
    [SubTypeDiscriminator("StandalonePriceValueChanged", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessagePayload))]
    [SubTypeDiscriminator("StoreCreated", typeof(commercetools.Sdk.Api.Models.Messages.StoreCreatedMessagePayload))]
    [SubTypeDiscriminator("StoreDeleted", typeof(commercetools.Sdk.Api.Models.Messages.StoreDeletedMessagePayload))]
    [SubTypeDiscriminator("StoreDistributionChannelsChanged", typeof(commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessagePayload))]
    [SubTypeDiscriminator("StoreProductSelectionsChanged", typeof(commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessagePayload))]
    public partial interface IMessagePayload
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessagePayload CategoryCreated(Action<commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessagePayload CategorySlugChanged(Action<commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessagePayload CustomerAddressAdded(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessagePayload CustomerAddressChanged(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessagePayload CustomerAddressRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessagePayload CustomerCompanyNameSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessagePayload CustomerCreated(Action<commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload CustomerDateOfBirthSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessagePayload CustomerDeleted(Action<commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessagePayload CustomerEmailChanged(Action<commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessagePayload CustomerEmailVerified(Action<commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessagePayload CustomerFirstNameSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessagePayload CustomerGroupSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessagePayload CustomerLastNameSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessagePayload CustomerPasswordUpdated(Action<commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessagePayload CustomerTitleSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessagePayload CustomLineItemStateTransition(Action<commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessagePayload DeliveryAdded(Action<commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessagePayload DeliveryAddressSet(Action<commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessagePayload DeliveryItemsUpdated(Action<commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessagePayload DeliveryRemoved(Action<commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessagePayload InventoryEntryCreated(Action<commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessagePayload InventoryEntryDeleted(Action<commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessagePayload InventoryEntryQuantitySet(Action<commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessagePayload LineItemStateTransition(Action<commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessagePayload OrderBillingAddressSet(Action<commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCreatedMessagePayload OrderCreated(Action<commercetools.Sdk.Api.Models.Messages.OrderCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessagePayload OrderCustomerEmailSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessagePayload OrderCustomerGroupSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessagePayload OrderCustomerSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessagePayload OrderCustomLineItemAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessagePayload OrderCustomLineItemDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessagePayload OrderCustomLineItemQuantityChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessagePayload OrderCustomLineItemRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderDeletedMessagePayload OrderDeleted(Action<commercetools.Sdk.Api.Models.Messages.OrderDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessagePayload OrderDiscountCodeAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessagePayload OrderDiscountCodeRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessagePayload OrderDiscountCodeStateSet(Action<commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessagePayload OrderEditApplied(Action<commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderImportedMessagePayload OrderImported(Action<commercetools.Sdk.Api.Models.Messages.OrderImportedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderImportedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessagePayload OrderLineItemAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessagePayload OrderLineItemDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessagePayload OrderLineItemDistributionChannelSet(Action<commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessagePayload OrderLineItemRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessagePayload OrderPaymentAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessagePayload OrderPaymentStateChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessagePayload OrderReturnShipmentStateChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessagePayload OrderShipmentStateChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessagePayload OrderShippingAddressSet(Action<commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessagePayload OrderShippingInfoSet(Action<commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessagePayload OrderShippingRateInputSet(Action<commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessagePayload OrderStateChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderStateTransitionMessagePayload OrderStateTransition(Action<commercetools.Sdk.Api.Models.Messages.OrderStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessagePayload OrderStoreSet(Action<commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessagePayload ParcelAddedToDelivery(Action<commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessagePayload ParcelItemsUpdated(Action<commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessagePayload ParcelMeasurementsUpdated(Action<commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessagePayload ParcelRemovedFromDelivery(Action<commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessagePayload ParcelTrackingDataUpdated(Action<commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessagePayload PaymentCreated(Action<commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessagePayload PaymentInteractionAdded(Action<commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload PaymentStatusInterfaceCodeSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessagePayload PaymentStatusStateTransition(Action<commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessagePayload PaymentTransactionAdded(Action<commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessagePayload PaymentTransactionStateChanged(Action<commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessagePayload ProductAddedToCategory(Action<commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductCreatedMessagePayload ProductCreated(Action<commercetools.Sdk.Api.Models.Messages.ProductCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductDeletedMessagePayload ProductDeleted(Action<commercetools.Sdk.Api.Models.Messages.ProductDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessagePayload ProductImageAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessagePayload ProductPriceDiscountsSet(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessagePayload ProductPriceExternalDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPublishedMessagePayload ProductPublished(Action<commercetools.Sdk.Api.Models.Messages.ProductPublishedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPublishedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessagePayload ProductRemovedFromCategory(Action<commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessagePayload ProductRevertedStagedChanges(Action<commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessagePayload ProductSelectionCreated(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessagePayload ProductSelectionDeleted(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessagePayload ProductSelectionProductAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessagePayload ProductSelectionProductRemoved(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessagePayload ProductSelectionVariantSelectionChanged(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessagePayload ProductSlugChanged(Action<commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessagePayload ProductStateTransition(Action<commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessagePayload ProductUnpublished(Action<commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessagePayload ProductVariantAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessagePayload ProductVariantDeleted(Action<commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessagePayload QuoteCreated(Action<commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteDeletedMessagePayload QuoteDeleted(Action<commercetools.Sdk.Api.Models.Messages.QuoteDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessagePayload QuoteRequestCreated(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestDeletedMessagePayload QuoteRequestDeleted(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessagePayload QuoteRequestStateChanged(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessagePayload QuoteRequestStateTransition(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessagePayload QuoteStateChanged(Action<commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessagePayload QuoteStateTransition(Action<commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessagePayload ReturnInfoAdded(Action<commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessagePayload ReturnInfoSet(Action<commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessagePayload ReviewCreated(Action<commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessagePayload ReviewRatingSet(Action<commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessagePayload ReviewStateTransition(Action<commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ShoppingListStoreSetMessagePayload ShoppingListStoreSet(Action<commercetools.Sdk.Api.Models.Messages.ShoppingListStoreSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ShoppingListStoreSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessagePayload StagedQuoteCreated(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteDeletedMessagePayload StagedQuoteDeleted(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessagePayload StagedQuoteSellerCommentSet(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessagePayload StagedQuoteStateChanged(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessagePayload StagedQuoteStateTransition(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessagePayload StagedQuoteValidToSet(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessagePayload StandalonePriceCreated(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessagePayload StandalonePriceDeleted(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessagePayload StandalonePriceDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessagePayload StandalonePriceExternalDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessagePayload StandalonePriceStagedChangesApplied(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessagePayload StandalonePriceValueChanged(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreCreatedMessagePayload StoreCreated(Action<commercetools.Sdk.Api.Models.Messages.StoreCreatedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreCreatedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreDeletedMessagePayload StoreDeleted(Action<commercetools.Sdk.Api.Models.Messages.StoreDeletedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreDeletedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessagePayload StoreDistributionChannelsChanged(Action<commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessagePayload StoreProductSelectionsChanged(Action<commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessagePayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessagePayload();
            init?.Invoke(t);
            return t;
        }
    }
}
