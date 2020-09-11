using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(OrderBillingAddressSetMessage), "OrderBillingAddressSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderCreatedMessage), "OrderCreated")]
    [JsonSubtypes.KnownSubType(typeof(OrderCustomLineItemDiscountSetMessage), "OrderCustomLineItemDiscountSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderCustomerEmailSetMessage), "OrderCustomerEmailSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderCustomerGroupSetMessage), "OrderCustomerGroupSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderCustomerSetMessage), "OrderCustomerSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderDeletedMessage), "OrderDeleted")]
    [JsonSubtypes.KnownSubType(typeof(OrderDiscountCodeAddedMessage), "OrderDiscountCodeAdded")]
    [JsonSubtypes.KnownSubType(typeof(OrderDiscountCodeRemovedMessage), "OrderDiscountCodeRemoved")]
    [JsonSubtypes.KnownSubType(typeof(OrderDiscountCodeStateSetMessage), "OrderDiscountCodeStateSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditAppliedMessage), "OrderEditApplied")]
    [JsonSubtypes.KnownSubType(typeof(OrderImportedMessage), "OrderImported")]
    [JsonSubtypes.KnownSubType(typeof(OrderLineItemAddedMessage), "OrderLineItemAdded")]
    [JsonSubtypes.KnownSubType(typeof(OrderLineItemDiscountSetMessage), "OrderLineItemDiscountSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderPaymentStateChangedMessage), "OrderPaymentStateChanged")]
    [JsonSubtypes.KnownSubType(typeof(OrderReturnInfoAddedMessage), "ReturnInfoAdded")]
    [JsonSubtypes.KnownSubType(typeof(OrderReturnShipmentStateChangedMessage), "OrderReturnShipmentStateChanged")]
    [JsonSubtypes.KnownSubType(typeof(OrderShipmentStateChangedMessage), "OrderShipmentStateChanged")]
    [JsonSubtypes.KnownSubType(typeof(OrderShippingAddressSetMessage), "OrderShippingAddressSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderShippingInfoSetMessage), "OrderShippingInfoSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderShippingRateInputSetMessage), "OrderShippingRateInputSet")]
    [JsonSubtypes.KnownSubType(typeof(OrderStateChangedMessage), "OrderStateChanged")]
    [JsonSubtypes.KnownSubType(typeof(OrderStateTransitionMessage), "OrderStateTransition")]
    [JsonSubtypes.KnownSubType(typeof(OrderStoreSetMessage), "OrderStoreSet")]
    [JsonSubtypes.KnownSubType(typeof(ParcelAddedToDeliveryMessage), "ParcelAddedToDelivery")]
    [JsonSubtypes.KnownSubType(typeof(ParcelItemsUpdatedMessage), "ParcelItemsUpdated")]
    [JsonSubtypes.KnownSubType(typeof(ParcelMeasurementsUpdatedMessage), "ParcelMeasurementsUpdated")]
    [JsonSubtypes.KnownSubType(typeof(ParcelRemovedFromDeliveryMessage), "ParcelRemovedFromDelivery")]
    [JsonSubtypes.KnownSubType(typeof(ParcelTrackingDataUpdatedMessage), "ParcelTrackingDataUpdated")]
    [JsonSubtypes.KnownSubType(typeof(PaymentCreatedMessage), "PaymentCreated")]
    [JsonSubtypes.KnownSubType(typeof(PaymentInteractionAddedMessage), "PaymentInteractionAdded")]
    [JsonSubtypes.KnownSubType(typeof(PaymentStatusInterfaceCodeSetMessage), "PaymentStatusInterfaceCodeSet")]
    [JsonSubtypes.KnownSubType(typeof(PaymentStatusStateTransitionMessage), "PaymentStatusStateTransition")]
    [JsonSubtypes.KnownSubType(typeof(PaymentTransactionAddedMessage), "PaymentTransactionAdded")]
    [JsonSubtypes.KnownSubType(typeof(PaymentTransactionStateChangedMessage), "PaymentTransactionStateChanged")]
    [JsonSubtypes.KnownSubType(typeof(ProductAddedToCategoryMessage), "ProductAddedToCategory")]
    [JsonSubtypes.KnownSubType(typeof(ProductCreatedMessage), "ProductCreated")]
    [JsonSubtypes.KnownSubType(typeof(ProductDeletedMessage), "ProductDeleted")]
    [JsonSubtypes.KnownSubType(typeof(ProductImageAddedMessage), "ProductImageAdded")]
    [JsonSubtypes.KnownSubType(typeof(ProductPriceDiscountsSetMessage), "ProductPriceDiscountsSet")]
    [JsonSubtypes.KnownSubType(typeof(ProductPriceExternalDiscountSetMessage), "ProductPriceExternalDiscountSet")]
    [JsonSubtypes.KnownSubType(typeof(ProductPublishedMessage), "ProductPublished")]
    [JsonSubtypes.KnownSubType(typeof(ProductRemovedFromCategoryMessage), "ProductRemovedFromCategory")]
    [JsonSubtypes.KnownSubType(typeof(ProductRevertedStagedChangesMessage), "ProductRevertedStagedChanges")]
    [JsonSubtypes.KnownSubType(typeof(ProductSlugChangedMessage), "ProductSlugChanged")]
    [JsonSubtypes.KnownSubType(typeof(ProductStateTransitionMessage), "ProductStateTransition")]
    [JsonSubtypes.KnownSubType(typeof(ProductUnpublishedMessage), "ProductUnpublished")]
    [JsonSubtypes.KnownSubType(typeof(ProductVariantDeletedMessage), "ProductVariantDeleted")]
    [JsonSubtypes.KnownSubType(typeof(ReviewCreatedMessage), "ReviewCreated")]
    [JsonSubtypes.KnownSubType(typeof(ReviewRatingSetMessage), "ReviewRatingSet")]
    [JsonSubtypes.KnownSubType(typeof(ReviewStateTransitionMessage), "ReviewStateTransition")]
    [JsonSubtypes.KnownSubType(typeof(DeliveryAddressSetMessage), "DeliveryAddressSet")]
    [JsonSubtypes.KnownSubType(typeof(CustomerEmailChangedMessage), "CustomerEmailChanged")]
    [JsonSubtypes.KnownSubType(typeof(DeliveryAddedMessage), "DeliveryAdded")]
    [JsonSubtypes.KnownSubType(typeof(CustomerAddressChangedMessage), "CustomerAddressChanged")]
    [JsonSubtypes.KnownSubType(typeof(CustomerEmailVerifiedMessage), "CustomerEmailVerified")]
    [JsonSubtypes.KnownSubType(typeof(CustomerAddressAddedMessage), "CustomerAddressAdded")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntryCreatedMessage), "InventoryEntryCreated")]
    [JsonSubtypes.KnownSubType(typeof(DeliveryRemovedMessage), "DeliveryRemoved")]
    [JsonSubtypes.KnownSubType(typeof(DeliveryItemsUpdatedMessage), "DeliveryItemsUpdated")]
    [JsonSubtypes.KnownSubType(typeof(CustomerGroupSetMessage), "CustomerGroupSet")]
    [JsonSubtypes.KnownSubType(typeof(CategoryCreatedMessage), "CategoryCreated")]
    [JsonSubtypes.KnownSubType(typeof(CustomerCreatedMessage), "CustomerCreated")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntryDeletedMessage), "InventoryEntryDeleted")]
    [JsonSubtypes.KnownSubType(typeof(LineItemStateTransitionMessage), "LineItemStateTransition")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntryQuantitySetMessage), "InventoryEntryQuantitySet")]
    [JsonSubtypes.KnownSubType(typeof(CustomerCompanyNameSetMessage), "CustomerCompanyNameSet")]
    [JsonSubtypes.KnownSubType(typeof(CustomerAddressRemovedMessage), "CustomerAddressRemoved")]
    [JsonSubtypes.KnownSubType(typeof(CategorySlugChangedMessage), "CategorySlugChanged")]
    [JsonSubtypes.KnownSubType(typeof(CustomerDateOfBirthSetMessage), "CustomerDateOfBirthSet")]
    [JsonSubtypes.KnownSubType(typeof(CustomLineItemStateTransitionMessage), "CustomLineItemStateTransition")]
    public abstract class Message : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public long SequenceNumber { get; set;}
        
        public Reference Resource { get; set;}
        
        public long ResourceVersion { get; set;}
        
        public string Type { get; set;}
        
        public UserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
