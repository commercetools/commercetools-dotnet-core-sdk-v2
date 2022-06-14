using commercetools.Sdk.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Messages.Message))]
    [SubTypeDiscriminator("CategoryCreated", typeof(commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessage))]
    [SubTypeDiscriminator("CategorySlugChanged", typeof(commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessage))]
    [SubTypeDiscriminator("CustomerAddressAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessage))]
    [SubTypeDiscriminator("CustomerAddressChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessage))]
    [SubTypeDiscriminator("CustomerAddressRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessage))]
    [SubTypeDiscriminator("CustomerCompanyNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessage))]
    [SubTypeDiscriminator("CustomerCreated", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessage))]
    [SubTypeDiscriminator("CustomerDateOfBirthSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessage))]
    [SubTypeDiscriminator("CustomerDeleted", typeof(commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessage))]
    [SubTypeDiscriminator("CustomerEmailChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessage))]
    [SubTypeDiscriminator("CustomerEmailVerified", typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessage))]
    [SubTypeDiscriminator("CustomerFirstNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessage))]
    [SubTypeDiscriminator("CustomerGroupSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessage))]
    [SubTypeDiscriminator("CustomerLastNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessage))]
    [SubTypeDiscriminator("CustomerPasswordUpdated", typeof(commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessage))]
    [SubTypeDiscriminator("CustomerTitleSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessage))]
    [SubTypeDiscriminator("CustomLineItemStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessage))]
    [SubTypeDiscriminator("DeliveryAdded", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessage))]
    [SubTypeDiscriminator("DeliveryAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessage))]
    [SubTypeDiscriminator("DeliveryItemsUpdated", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessage))]
    [SubTypeDiscriminator("DeliveryRemoved", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessage))]
    [SubTypeDiscriminator("InventoryEntryCreated", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessage))]
    [SubTypeDiscriminator("InventoryEntryDeleted", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessage))]
    [SubTypeDiscriminator("InventoryEntryQuantitySet", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessage))]
    [SubTypeDiscriminator("LineItemStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessage))]
    [SubTypeDiscriminator("OrderBillingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessage))]
    [SubTypeDiscriminator("OrderCreated", typeof(commercetools.Sdk.Api.Models.Messages.OrderCreatedMessage))]
    [SubTypeDiscriminator("OrderCustomerEmailSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessage))]
    [SubTypeDiscriminator("OrderCustomerGroupSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessage))]
    [SubTypeDiscriminator("OrderCustomerSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessage))]
    [SubTypeDiscriminator("OrderCustomLineItemDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage))]
    [SubTypeDiscriminator("OrderDeleted", typeof(commercetools.Sdk.Api.Models.Messages.OrderDeletedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeStateSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessage))]
    [SubTypeDiscriminator("OrderEditApplied", typeof(commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessage))]
    [SubTypeDiscriminator("OrderImported", typeof(commercetools.Sdk.Api.Models.Messages.OrderImportedMessage))]
    [SubTypeDiscriminator("OrderLineItemAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessage))]
    [SubTypeDiscriminator("OrderLineItemDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessage))]
    [SubTypeDiscriminator("OrderLineItemDistributionChannelSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessage))]
    [SubTypeDiscriminator("OrderLineItemRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessage))]
    [SubTypeDiscriminator("OrderPaymentAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessage))]
    [SubTypeDiscriminator("OrderPaymentStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessage))]
    [SubTypeDiscriminator("OrderReturnShipmentStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessage))]
    [SubTypeDiscriminator("OrderShipmentStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessage))]
    [SubTypeDiscriminator("OrderShippingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessage))]
    [SubTypeDiscriminator("OrderShippingInfoSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessage))]
    [SubTypeDiscriminator("OrderShippingRateInputSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessage))]
    [SubTypeDiscriminator("OrderStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessage))]
    [SubTypeDiscriminator("OrderStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.OrderStateTransitionMessage))]
    [SubTypeDiscriminator("OrderStoreSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessage))]
    [SubTypeDiscriminator("ParcelAddedToDelivery", typeof(commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessage))]
    [SubTypeDiscriminator("ParcelItemsUpdated", typeof(commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessage))]
    [SubTypeDiscriminator("ParcelMeasurementsUpdated", typeof(commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessage))]
    [SubTypeDiscriminator("ParcelRemovedFromDelivery", typeof(commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessage))]
    [SubTypeDiscriminator("ParcelTrackingDataUpdated", typeof(commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessage))]
    [SubTypeDiscriminator("PaymentCreated", typeof(commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessage))]
    [SubTypeDiscriminator("PaymentInteractionAdded", typeof(commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessage))]
    [SubTypeDiscriminator("PaymentStatusInterfaceCodeSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage))]
    [SubTypeDiscriminator("PaymentStatusStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessage))]
    [SubTypeDiscriminator("PaymentTransactionAdded", typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessage))]
    [SubTypeDiscriminator("PaymentTransactionStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessage))]
    [SubTypeDiscriminator("ProductAddedToCategory", typeof(commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessage))]
    [SubTypeDiscriminator("ProductCreated", typeof(commercetools.Sdk.Api.Models.Messages.ProductCreatedMessage))]
    [SubTypeDiscriminator("ProductDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductDeletedMessage))]
    [SubTypeDiscriminator("ProductImageAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessage))]
    [SubTypeDiscriminator("ProductPriceDiscountsSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessage))]
    [SubTypeDiscriminator("ProductPriceExternalDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessage))]
    [SubTypeDiscriminator("ProductPublished", typeof(commercetools.Sdk.Api.Models.Messages.ProductPublishedMessage))]
    [SubTypeDiscriminator("ProductRemovedFromCategory", typeof(commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessage))]
    [SubTypeDiscriminator("ProductRevertedStagedChanges", typeof(commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessage))]
    [SubTypeDiscriminator("ProductSelectionCreated", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessage))]
    [SubTypeDiscriminator("ProductSelectionDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessage))]
    [SubTypeDiscriminator("ProductSelectionProductAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessage))]
    [SubTypeDiscriminator("ProductSelectionProductRemoved", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessage))]
    [SubTypeDiscriminator("ProductSlugChanged", typeof(commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessage))]
    [SubTypeDiscriminator("ProductStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessage))]
    [SubTypeDiscriminator("ProductUnpublished", typeof(commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessage))]
    [SubTypeDiscriminator("ProductVariantAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessage))]
    [SubTypeDiscriminator("ProductVariantDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessage))]
    [SubTypeDiscriminator("ReturnInfoAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnInfoAddedMessage))]
    [SubTypeDiscriminator("ReturnInfoSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnInfoSetMessage))]
    [SubTypeDiscriminator("ReviewCreated", typeof(commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessage))]
    [SubTypeDiscriminator("ReviewRatingSet", typeof(commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessage))]
    [SubTypeDiscriminator("ReviewStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessage))]
    [SubTypeDiscriminator("StandalonePriceCreated", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessage))]
    [SubTypeDiscriminator("StandalonePriceDeleted", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessage))]
    [SubTypeDiscriminator("StandalonePriceDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessage))]
    [SubTypeDiscriminator("StandalonePriceExternalDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessage))]
    [SubTypeDiscriminator("StandalonePriceValueChanged", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessage))]
    [SubTypeDiscriminator("StoreCreated", typeof(commercetools.Sdk.Api.Models.Messages.StoreCreatedMessage))]
    [SubTypeDiscriminator("StoreDeleted", typeof(commercetools.Sdk.Api.Models.Messages.StoreDeletedMessage))]
    [SubTypeDiscriminator("StoreProductSelectionsChanged", typeof(commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessage))]
    public partial interface IMessage : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        long SequenceNumber { get; set; }

        IReference Resource { get; set; }

        long ResourceVersion { get; set; }

        string Type { get; set; }

        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }
    }
}
