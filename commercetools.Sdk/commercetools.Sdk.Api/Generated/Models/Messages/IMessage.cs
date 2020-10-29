using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("OrderBillingAddressSet", typeof(commercetools.Api.Models.Messages.OrderBillingAddressSetMessage))]
    [SubTypeDiscriminator("OrderCreated", typeof(commercetools.Api.Models.Messages.OrderCreatedMessage))]
    [SubTypeDiscriminator("OrderCustomLineItemDiscountSet", typeof(commercetools.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage))]
    [SubTypeDiscriminator("OrderCustomerEmailSet", typeof(commercetools.Api.Models.Messages.OrderCustomerEmailSetMessage))]
    [SubTypeDiscriminator("OrderCustomerGroupSet", typeof(commercetools.Api.Models.Messages.OrderCustomerGroupSetMessage))]
    [SubTypeDiscriminator("OrderCustomerSet", typeof(commercetools.Api.Models.Messages.OrderCustomerSetMessage))]
    [SubTypeDiscriminator("OrderDeleted", typeof(commercetools.Api.Models.Messages.OrderDeletedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeAdded", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeAddedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeRemoved", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeRemovedMessage))]
    [SubTypeDiscriminator("OrderDiscountCodeStateSet", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeStateSetMessage))]
    [SubTypeDiscriminator("OrderEditApplied", typeof(commercetools.Api.Models.Messages.OrderEditAppliedMessage))]
    [SubTypeDiscriminator("OrderImported", typeof(commercetools.Api.Models.Messages.OrderImportedMessage))]
    [SubTypeDiscriminator("OrderLineItemAdded", typeof(commercetools.Api.Models.Messages.OrderLineItemAddedMessage))]
    [SubTypeDiscriminator("OrderLineItemDiscountSet", typeof(commercetools.Api.Models.Messages.OrderLineItemDiscountSetMessage))]
    [SubTypeDiscriminator("OrderPaymentStateChanged", typeof(commercetools.Api.Models.Messages.OrderPaymentStateChangedMessage))]
    [SubTypeDiscriminator("ReturnInfoAdded", typeof(commercetools.Api.Models.Messages.OrderReturnInfoAddedMessage))]
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
    [SubTypeDiscriminator("ProductVariantDeleted", typeof(commercetools.Api.Models.Messages.ProductVariantDeletedMessage))]
    [SubTypeDiscriminator("ReviewCreated", typeof(commercetools.Api.Models.Messages.ReviewCreatedMessage))]
    [SubTypeDiscriminator("ReviewRatingSet", typeof(commercetools.Api.Models.Messages.ReviewRatingSetMessage))]
    [SubTypeDiscriminator("ReviewStateTransition", typeof(commercetools.Api.Models.Messages.ReviewStateTransitionMessage))]
    [SubTypeDiscriminator("InventoryEntryCreated", typeof(commercetools.Api.Models.Messages.InventoryEntryCreatedMessage))]
    [SubTypeDiscriminator("DeliveryRemoved", typeof(commercetools.Api.Models.Messages.DeliveryRemovedMessage))]
    [SubTypeDiscriminator("LineItemStateTransition", typeof(commercetools.Api.Models.Messages.LineItemStateTransitionMessage))]
    [SubTypeDiscriminator("CustomerCompanyNameSet", typeof(commercetools.Api.Models.Messages.CustomerCompanyNameSetMessage))]
    [SubTypeDiscriminator("DeliveryAddressSet", typeof(commercetools.Api.Models.Messages.DeliveryAddressSetMessage))]
    [SubTypeDiscriminator("CustomerCreated", typeof(commercetools.Api.Models.Messages.CustomerCreatedMessage))]
    [SubTypeDiscriminator("CustomerEmailVerified", typeof(commercetools.Api.Models.Messages.CustomerEmailVerifiedMessage))]
    [SubTypeDiscriminator("CustomerAddressRemoved", typeof(commercetools.Api.Models.Messages.CustomerAddressRemovedMessage))]
    [SubTypeDiscriminator("CustomerAddressChanged", typeof(commercetools.Api.Models.Messages.CustomerAddressChangedMessage))]
    [SubTypeDiscriminator("CategoryCreated", typeof(commercetools.Api.Models.Messages.CategoryCreatedMessage))]
    [SubTypeDiscriminator("DeliveryAdded", typeof(commercetools.Api.Models.Messages.DeliveryAddedMessage))]
    [SubTypeDiscriminator("CustomerAddressAdded", typeof(commercetools.Api.Models.Messages.CustomerAddressAddedMessage))]
    [SubTypeDiscriminator("CustomerGroupSet", typeof(commercetools.Api.Models.Messages.CustomerGroupSetMessage))]
    [SubTypeDiscriminator("DeliveryItemsUpdated", typeof(commercetools.Api.Models.Messages.DeliveryItemsUpdatedMessage))]
    [SubTypeDiscriminator("CustomerEmailChanged", typeof(commercetools.Api.Models.Messages.CustomerEmailChangedMessage))]
    [SubTypeDiscriminator("InventoryEntryDeleted", typeof(commercetools.Api.Models.Messages.InventoryEntryDeletedMessage))]
    [SubTypeDiscriminator("CategorySlugChanged", typeof(commercetools.Api.Models.Messages.CategorySlugChangedMessage))]
    [SubTypeDiscriminator("InventoryEntryQuantitySet", typeof(commercetools.Api.Models.Messages.InventoryEntryQuantitySetMessage))]
    [SubTypeDiscriminator("CustomerDateOfBirthSet", typeof(commercetools.Api.Models.Messages.CustomerDateOfBirthSetMessage))]
    [SubTypeDiscriminator("CustomLineItemStateTransition", typeof(commercetools.Api.Models.Messages.CustomLineItemStateTransitionMessage))]
    public interface IMessage : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        long SequenceNumber { get; set;}
        
        IReference Resource { get; set;}
        
        long ResourceVersion { get; set;}
        
        string Type { get; set;}
        
        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
