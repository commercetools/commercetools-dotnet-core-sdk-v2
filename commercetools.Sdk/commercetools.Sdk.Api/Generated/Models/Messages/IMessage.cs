using commercetools.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Messages.Message))]
    [SubTypeDiscriminator("CategoryCreated", typeof(commercetools.Api.Models.Messages.CategoryCreatedMessage))]
    [SubTypeDiscriminator("CategorySlugChanged", typeof(commercetools.Api.Models.Messages.CategorySlugChangedMessage))]
    [SubTypeDiscriminator("CustomerAddressAdded", typeof(commercetools.Api.Models.Messages.CustomerAddressAddedMessage))]
    [SubTypeDiscriminator("CustomerAddressChanged", typeof(commercetools.Api.Models.Messages.CustomerAddressChangedMessage))]
    [SubTypeDiscriminator("CustomerAddressRemoved", typeof(commercetools.Api.Models.Messages.CustomerAddressRemovedMessage))]
    [SubTypeDiscriminator("CustomerCompanyNameSet", typeof(commercetools.Api.Models.Messages.CustomerCompanyNameSetMessage))]
    [SubTypeDiscriminator("CustomerCreated", typeof(commercetools.Api.Models.Messages.CustomerCreatedMessage))]
    [SubTypeDiscriminator("CustomerDateOfBirthSet", typeof(commercetools.Api.Models.Messages.CustomerDateOfBirthSetMessage))]
    [SubTypeDiscriminator("CustomerDeleted", typeof(commercetools.Api.Models.Messages.CustomerDeletedMessage))]
    [SubTypeDiscriminator("CustomerEmailChanged", typeof(commercetools.Api.Models.Messages.CustomerEmailChangedMessage))]
    [SubTypeDiscriminator("CustomerEmailVerified", typeof(commercetools.Api.Models.Messages.CustomerEmailVerifiedMessage))]
    [SubTypeDiscriminator("CustomerFirstNameSet", typeof(commercetools.Api.Models.Messages.CustomerFirstNameSetMessage))]
    [SubTypeDiscriminator("CustomerGroupSet", typeof(commercetools.Api.Models.Messages.CustomerGroupSetMessage))]
    [SubTypeDiscriminator("CustomerLastNameSet", typeof(commercetools.Api.Models.Messages.CustomerLastNameSetMessage))]
    [SubTypeDiscriminator("CustomerPasswordUpdated", typeof(commercetools.Api.Models.Messages.CustomerPasswordUpdatedMessage))]
    [SubTypeDiscriminator("CustomerTitleSet", typeof(commercetools.Api.Models.Messages.CustomerTitleSetMessage))]
    [SubTypeDiscriminator("CustomLineItemStateTransition", typeof(commercetools.Api.Models.Messages.CustomLineItemStateTransitionMessage))]
    [SubTypeDiscriminator("DeliveryAdded", typeof(commercetools.Api.Models.Messages.DeliveryAddedMessage))]
    [SubTypeDiscriminator("DeliveryAddressSet", typeof(commercetools.Api.Models.Messages.DeliveryAddressSetMessage))]
    [SubTypeDiscriminator("DeliveryItemsUpdated", typeof(commercetools.Api.Models.Messages.DeliveryItemsUpdatedMessage))]
    [SubTypeDiscriminator("DeliveryRemoved", typeof(commercetools.Api.Models.Messages.DeliveryRemovedMessage))]
    [SubTypeDiscriminator("InventoryEntryCreated", typeof(commercetools.Api.Models.Messages.InventoryEntryCreatedMessage))]
    [SubTypeDiscriminator("InventoryEntryDeleted", typeof(commercetools.Api.Models.Messages.InventoryEntryDeletedMessage))]
    [SubTypeDiscriminator("InventoryEntryQuantitySet", typeof(commercetools.Api.Models.Messages.InventoryEntryQuantitySetMessage))]
    [SubTypeDiscriminator("LineItemStateTransition", typeof(commercetools.Api.Models.Messages.LineItemStateTransitionMessage))]
    [SubTypeDiscriminator("OrderBillingAddressSet", typeof(commercetools.Api.Models.Messages.OrderBillingAddressSetMessage))]
    [SubTypeDiscriminator("OrderCreated", typeof(commercetools.Api.Models.Messages.OrderCreatedMessage))]
    [SubTypeDiscriminator("OrderCustomerEmailSet", typeof(commercetools.Api.Models.Messages.OrderCustomerEmailSetMessage))]
    [SubTypeDiscriminator("OrderCustomerGroupSet", typeof(commercetools.Api.Models.Messages.OrderCustomerGroupSetMessage))]
    [SubTypeDiscriminator("OrderCustomerSet", typeof(commercetools.Api.Models.Messages.OrderCustomerSetMessage))]
    [SubTypeDiscriminator("OrderCustomLineItemDiscountSet", typeof(commercetools.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage))]
    [SubTypeDiscriminator("OrderDeleted", typeof(commercetools.Api.Models.Messages.OrderDeletedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeAdded", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeAddedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeRemoved", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeRemovedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeStateSet", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeStateSetMessage))]
    [SubTypeDiscriminator("OrderEditApplied", typeof(commercetools.Api.Models.Messages.OrderEditAppliedMessage))]
    [SubTypeDiscriminator("OrderImported", typeof(commercetools.Api.Models.Messages.OrderImportedMessage))]
    [SubTypeDiscriminator("OrderLineItemAdded", typeof(commercetools.Api.Models.Messages.OrderLineItemAddedMessage))]
    [SubTypeDiscriminator("OrderLineItemDiscountSet", typeof(commercetools.Api.Models.Messages.OrderLineItemDiscountSetMessage))]
    [SubTypeDiscriminator("OrderPaymentStateChanged", typeof(commercetools.Api.Models.Messages.OrderPaymentStateChangedMessage))]
    [SubTypeDiscriminator("OrderReturnShipmentStateChanged", typeof(commercetools.Api.Models.Messages.OrderReturnShipmentStateChangedMessage))]
    [SubTypeDiscriminator("OrderShipmentStateChanged", typeof(commercetools.Api.Models.Messages.OrderShipmentStateChangedMessage))]
    [SubTypeDiscriminator("OrderShippingAddressSet", typeof(commercetools.Api.Models.Messages.OrderShippingAddressSetMessage))]
    [SubTypeDiscriminator("OrderShippingInfoSet", typeof(commercetools.Api.Models.Messages.OrderShippingInfoSetMessage))]
    [SubTypeDiscriminator("OrderShippingRateInputSet", typeof(commercetools.Api.Models.Messages.OrderShippingRateInputSetMessage))]
    [SubTypeDiscriminator("OrderStateChanged", typeof(commercetools.Api.Models.Messages.OrderStateChangedMessage))]
    [SubTypeDiscriminator("OrderStateTransition", typeof(commercetools.Api.Models.Messages.OrderStateTransitionMessage))]
    [SubTypeDiscriminator("OrderStoreSet", typeof(commercetools.Api.Models.Messages.OrderStoreSetMessage))]
    [SubTypeDiscriminator("ParcelAddedToDelivery", typeof(commercetools.Api.Models.Messages.ParcelAddedToDeliveryMessage))]
    [SubTypeDiscriminator("ParcelItemsUpdated", typeof(commercetools.Api.Models.Messages.ParcelItemsUpdatedMessage))]
    [SubTypeDiscriminator("ParcelMeasurementsUpdated", typeof(commercetools.Api.Models.Messages.ParcelMeasurementsUpdatedMessage))]
    [SubTypeDiscriminator("ParcelRemovedFromDelivery", typeof(commercetools.Api.Models.Messages.ParcelRemovedFromDeliveryMessage))]
    [SubTypeDiscriminator("ParcelTrackingDataUpdated", typeof(commercetools.Api.Models.Messages.ParcelTrackingDataUpdatedMessage))]
    [SubTypeDiscriminator("PaymentCreated", typeof(commercetools.Api.Models.Messages.PaymentCreatedMessage))]
    [SubTypeDiscriminator("PaymentInteractionAdded", typeof(commercetools.Api.Models.Messages.PaymentInteractionAddedMessage))]
    [SubTypeDiscriminator("PaymentStatusInterfaceCodeSet", typeof(commercetools.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage))]
    [SubTypeDiscriminator("PaymentStatusStateTransition", typeof(commercetools.Api.Models.Messages.PaymentStatusStateTransitionMessage))]
    [SubTypeDiscriminator("PaymentTransactionAdded", typeof(commercetools.Api.Models.Messages.PaymentTransactionAddedMessage))]
    [SubTypeDiscriminator("PaymentTransactionStateChanged", typeof(commercetools.Api.Models.Messages.PaymentTransactionStateChangedMessage))]
    [SubTypeDiscriminator("ProductAddedToCategory", typeof(commercetools.Api.Models.Messages.ProductAddedToCategoryMessage))]
    [SubTypeDiscriminator("ProductCreated", typeof(commercetools.Api.Models.Messages.ProductCreatedMessage))]
    [SubTypeDiscriminator("ProductDeleted", typeof(commercetools.Api.Models.Messages.ProductDeletedMessage))]
    [SubTypeDiscriminator("ProductImageAdded", typeof(commercetools.Api.Models.Messages.ProductImageAddedMessage))]
    [SubTypeDiscriminator("ProductPriceDiscountsSet", typeof(commercetools.Api.Models.Messages.ProductPriceDiscountsSetMessage))]
    [SubTypeDiscriminator("ProductPriceExternalDiscountSet", typeof(commercetools.Api.Models.Messages.ProductPriceExternalDiscountSetMessage))]
    [SubTypeDiscriminator("ProductPublished", typeof(commercetools.Api.Models.Messages.ProductPublishedMessage))]
    [SubTypeDiscriminator("ProductRemovedFromCategory", typeof(commercetools.Api.Models.Messages.ProductRemovedFromCategoryMessage))]
    [SubTypeDiscriminator("ProductRevertedStagedChanges", typeof(commercetools.Api.Models.Messages.ProductRevertedStagedChangesMessage))]
    [SubTypeDiscriminator("ProductSlugChanged", typeof(commercetools.Api.Models.Messages.ProductSlugChangedMessage))]
    [SubTypeDiscriminator("ProductStateTransition", typeof(commercetools.Api.Models.Messages.ProductStateTransitionMessage))]
    [SubTypeDiscriminator("ProductUnpublished", typeof(commercetools.Api.Models.Messages.ProductUnpublishedMessage))]
    [SubTypeDiscriminator("ProductVariantAdded", typeof(commercetools.Api.Models.Messages.ProductVariantAddedMessage))]
    [SubTypeDiscriminator("ProductVariantDeleted", typeof(commercetools.Api.Models.Messages.ProductVariantDeletedMessage))]
    [SubTypeDiscriminator("ReturnInfoAdded", typeof(commercetools.Api.Models.Messages.OrderReturnInfoAddedMessage))]
    [SubTypeDiscriminator("ReturnInfoSet", typeof(commercetools.Api.Models.Messages.OrderReturnInfoSetMessage))]
    [SubTypeDiscriminator("ReviewCreated", typeof(commercetools.Api.Models.Messages.ReviewCreatedMessage))]
    [SubTypeDiscriminator("ReviewRatingSet", typeof(commercetools.Api.Models.Messages.ReviewRatingSetMessage))]
    [SubTypeDiscriminator("ReviewStateTransition", typeof(commercetools.Api.Models.Messages.ReviewStateTransitionMessage))]
    [SubTypeDiscriminator("StoreCreated", typeof(commercetools.Api.Models.Messages.StoreCreatedMessage))]
    [SubTypeDiscriminator("StoreDeleted", typeof(commercetools.Api.Models.Messages.StoreDeletedMessage))]
    public partial interface IMessage : IBaseResource
    {
        new string Id { get; set;}
        
        new long Version { get; set;}
        
        new DateTime CreatedAt { get; set;}
        
        new DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        long SequenceNumber { get; set;}
        
        IReference Resource { get; set;}
        
        long ResourceVersion { get; set;}
        
        string Type { get; set;}
        
        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
