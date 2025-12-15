using commercetools.Sdk.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Messages.Message))]
    [SubTypeDiscriminator("ApprovalFlowApproved", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowApprovedMessage))]
    [SubTypeDiscriminator("ApprovalFlowCompleted", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowCompletedMessage))]
    [SubTypeDiscriminator("ApprovalFlowCreated", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowCreatedMessage))]
    [SubTypeDiscriminator("ApprovalFlowRejected", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowRejectedMessage))]
    [SubTypeDiscriminator("ApprovalRuleApproversSet", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleApproversSetMessage))]
    [SubTypeDiscriminator("ApprovalRuleCreated", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleCreatedMessage))]
    [SubTypeDiscriminator("ApprovalRuleDescriptionSet", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleDescriptionSetMessage))]
    [SubTypeDiscriminator("ApprovalRuleKeySet", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleKeySetMessage))]
    [SubTypeDiscriminator("ApprovalRuleNameSet", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleNameSetMessage))]
    [SubTypeDiscriminator("ApprovalRulePredicateSet", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRulePredicateSetMessage))]
    [SubTypeDiscriminator("ApprovalRuleRequestersSet", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleRequestersSetMessage))]
    [SubTypeDiscriminator("ApprovalRuleStatusSet", typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleStatusSetMessage))]
    [SubTypeDiscriminator("AssociateRoleBuyerAssignableChanged", typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleBuyerAssignableChangedMessage))]
    [SubTypeDiscriminator("AssociateRoleCreated", typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleCreatedMessage))]
    [SubTypeDiscriminator("AssociateRoleDeleted", typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleDeletedMessage))]
    [SubTypeDiscriminator("AssociateRoleNameSet", typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleNameSetMessage))]
    [SubTypeDiscriminator("AssociateRolePermissionAdded", typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionAddedMessage))]
    [SubTypeDiscriminator("AssociateRolePermissionRemoved", typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionRemovedMessage))]
    [SubTypeDiscriminator("AssociateRolePermissionsSet", typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionsSetMessage))]
    [SubTypeDiscriminator("BusinessUnitAddressAdded", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressAddedMessage))]
    [SubTypeDiscriminator("BusinessUnitAddressChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitAddressCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldAddedMessage))]
    [SubTypeDiscriminator("BusinessUnitAddressCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitAddressCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitAddressCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitAddressCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeSetMessage))]
    [SubTypeDiscriminator("BusinessUnitAddressRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitApprovalRuleModeChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitApprovalRuleModeChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitAssociateAdded", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateAddedMessage))]
    [SubTypeDiscriminator("BusinessUnitAssociateChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitAssociateModeChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateModeChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitAssociateRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitAssociatesSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociatesSetMessage))]
    [SubTypeDiscriminator("BusinessUnitBillingAddressAdded", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressAddedMessage))]
    [SubTypeDiscriminator("BusinessUnitBillingAddressRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitContactEmailSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitContactEmailSetMessage))]
    [SubTypeDiscriminator("BusinessUnitCreated", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCreatedMessage))]
    [SubTypeDiscriminator("BusinessUnitCustomerGroupAssignmentAdded", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentAddedMessage))]
    [SubTypeDiscriminator("BusinessUnitCustomerGroupAssignmentRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitCustomerGroupAssignmentsSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentsSetMessage))]
    [SubTypeDiscriminator("BusinessUnitCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldAddedMessage))]
    [SubTypeDiscriminator("BusinessUnitCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeSetMessage))]
    [SubTypeDiscriminator("BusinessUnitDefaultBillingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultBillingAddressSetMessage))]
    [SubTypeDiscriminator("BusinessUnitDefaultShippingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultShippingAddressSetMessage))]
    [SubTypeDiscriminator("BusinessUnitDeleted", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitDeletedMessage))]
    [SubTypeDiscriminator("BusinessUnitNameChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitNameChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitParentChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitParentChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitShippingAddressAdded", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitShippingAddressAddedMessage))]
    [SubTypeDiscriminator("BusinessUnitShippingAddressRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitShippingAddressRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitStatusChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStatusChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitStoreAdded", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreAddedMessage))]
    [SubTypeDiscriminator("BusinessUnitStoreModeChanged", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreModeChangedMessage))]
    [SubTypeDiscriminator("BusinessUnitStoreRemoved", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreRemovedMessage))]
    [SubTypeDiscriminator("BusinessUnitStoresSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoresSetMessage))]
    [SubTypeDiscriminator("BusinessUnitTopLevelUnitSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitTopLevelUnitSetMessage))]
    [SubTypeDiscriminator("BusinessUnitTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitTypeSetMessage))]
    [SubTypeDiscriminator("CartDiscountCreated", typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountCreatedMessage))]
    [SubTypeDiscriminator("CartDiscountDeleted", typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountDeletedMessage))]
    [SubTypeDiscriminator("CartDiscountStoreAdded", typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountStoreAddedMessage))]
    [SubTypeDiscriminator("CartDiscountStoreRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountStoreRemovedMessage))]
    [SubTypeDiscriminator("CartDiscountStoresSet", typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountStoresSetMessage))]
    [SubTypeDiscriminator("CartFrozen", typeof(commercetools.Sdk.Api.Models.Messages.CartFrozenMessage))]
    [SubTypeDiscriminator("CartUnfrozen", typeof(commercetools.Sdk.Api.Models.Messages.CartUnfrozenMessage))]
    [SubTypeDiscriminator("CategoryCreated", typeof(commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessage))]
    [SubTypeDiscriminator("CategorySlugChanged", typeof(commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessage))]
    [SubTypeDiscriminator("CustomerAddressAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessage))]
    [SubTypeDiscriminator("CustomerAddressChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessage))]
    [SubTypeDiscriminator("CustomerAddressCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldAddedMessage))]
    [SubTypeDiscriminator("CustomerAddressCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldChangedMessage))]
    [SubTypeDiscriminator("CustomerAddressCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("CustomerAddressCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("CustomerAddressCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeSetMessage))]
    [SubTypeDiscriminator("CustomerAddressRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessage))]
    [SubTypeDiscriminator("CustomerBillingAddressAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressAddedMessage))]
    [SubTypeDiscriminator("CustomerBillingAddressRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressRemovedMessage))]
    [SubTypeDiscriminator("CustomerCompanyNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessage))]
    [SubTypeDiscriminator("CustomerCreated", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessage))]
    [SubTypeDiscriminator("CustomerCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldAddedMessage))]
    [SubTypeDiscriminator("CustomerCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldChangedMessage))]
    [SubTypeDiscriminator("CustomerCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("CustomerCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("CustomerCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeSetMessage))]
    [SubTypeDiscriminator("CustomerDateOfBirthSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessage))]
    [SubTypeDiscriminator("CustomerDefaultBillingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerDefaultBillingAddressSetMessage))]
    [SubTypeDiscriminator("CustomerDefaultShippingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerDefaultShippingAddressSetMessage))]
    [SubTypeDiscriminator("CustomerDeleted", typeof(commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessage))]
    [SubTypeDiscriminator("CustomerEmailChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessage))]
    [SubTypeDiscriminator("CustomerEmailTokenCreated", typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailTokenCreatedMessage))]
    [SubTypeDiscriminator("CustomerEmailVerified", typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessage))]
    [SubTypeDiscriminator("CustomerExternalIdSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerExternalIdSetMessage))]
    [SubTypeDiscriminator("CustomerFirstNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessage))]
    [SubTypeDiscriminator("CustomerGroupAssignmentAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentAddedMessage))]
    [SubTypeDiscriminator("CustomerGroupAssignmentRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentRemovedMessage))]
    [SubTypeDiscriminator("CustomerGroupAssignmentsSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentsSetMessage))]
    [SubTypeDiscriminator("CustomerGroupCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldAddedMessage))]
    [SubTypeDiscriminator("CustomerGroupCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldChangedMessage))]
    [SubTypeDiscriminator("CustomerGroupCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("CustomerGroupCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("CustomerGroupCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeSetMessage))]
    [SubTypeDiscriminator("CustomerGroupSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessage))]
    [SubTypeDiscriminator("CustomerLastNameSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessage))]
    [SubTypeDiscriminator("CustomerPasswordTokenCreated", typeof(commercetools.Sdk.Api.Models.Messages.CustomerPasswordTokenCreatedMessage))]
    [SubTypeDiscriminator("CustomerPasswordUpdated", typeof(commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessage))]
    [SubTypeDiscriminator("CustomerShippingAddressAdded", typeof(commercetools.Sdk.Api.Models.Messages.CustomerShippingAddressAddedMessage))]
    [SubTypeDiscriminator("CustomerShippingAddressRemoved", typeof(commercetools.Sdk.Api.Models.Messages.CustomerShippingAddressRemovedMessage))]
    [SubTypeDiscriminator("CustomerStoresSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerStoresSetMessage))]
    [SubTypeDiscriminator("CustomerTitleSet", typeof(commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessage))]
    [SubTypeDiscriminator("CustomLineItemStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessage))]
    [SubTypeDiscriminator("DeliveryAdded", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessage))]
    [SubTypeDiscriminator("DeliveryAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessage))]
    [SubTypeDiscriminator("DeliveryCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldAddedMessage))]
    [SubTypeDiscriminator("DeliveryCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldChangedMessage))]
    [SubTypeDiscriminator("DeliveryCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("DeliveryCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("DeliveryCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeSetMessage))]
    [SubTypeDiscriminator("DeliveryItemsUpdated", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessage))]
    [SubTypeDiscriminator("DeliveryRemoved", typeof(commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessage))]
    [SubTypeDiscriminator("DiscountCodeCreated", typeof(commercetools.Sdk.Api.Models.Messages.DiscountCodeCreatedMessage))]
    [SubTypeDiscriminator("DiscountCodeDeleted", typeof(commercetools.Sdk.Api.Models.Messages.DiscountCodeDeletedMessage))]
    [SubTypeDiscriminator("DiscountCodeKeySet", typeof(commercetools.Sdk.Api.Models.Messages.DiscountCodeKeySetMessage))]
    [SubTypeDiscriminator("DiscountGroupCreated", typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupCreatedMessage))]
    [SubTypeDiscriminator("DiscountGroupDeleted", typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupDeletedMessage))]
    [SubTypeDiscriminator("DiscountGroupIsActiveSet", typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupIsActiveSetMessage))]
    [SubTypeDiscriminator("DiscountGroupKeySet", typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupKeySetMessage))]
    [SubTypeDiscriminator("DiscountGroupSortOrderSet", typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupSortOrderSetMessage))]
    [SubTypeDiscriminator("InventoryEntryCreated", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessage))]
    [SubTypeDiscriminator("InventoryEntryDeleted", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessage))]
    [SubTypeDiscriminator("InventoryEntryQuantitySet", typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessage))]
    [SubTypeDiscriminator("LineItemStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessage))]
    [SubTypeDiscriminator("OrderBillingAddressSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessage))]
    [SubTypeDiscriminator("OrderBusinessUnitSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderBusinessUnitSetMessage))]
    [SubTypeDiscriminator("OrderCreated", typeof(commercetools.Sdk.Api.Models.Messages.OrderCreatedMessage))]
    [SubTypeDiscriminator("OrderCreatedFromRecurringOrder", typeof(commercetools.Sdk.Api.Models.Messages.OrderCreatedFromRecurringOrderMessage))]
    [SubTypeDiscriminator("OrderCustomerEmailSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessage))]
    [SubTypeDiscriminator("OrderCustomerGroupSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessage))]
    [SubTypeDiscriminator("OrderCustomerSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessage))]
    [SubTypeDiscriminator("OrderCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomFieldAddedMessage))]
    [SubTypeDiscriminator("OrderCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomFieldChangedMessage))]
    [SubTypeDiscriminator("OrderCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("OrderCustomLineItemAdded", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessage))]
    [SubTypeDiscriminator("OrderCustomLineItemDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage))]
    [SubTypeDiscriminator("OrderCustomLineItemQuantityChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessage))]
    [SubTypeDiscriminator("OrderCustomLineItemRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessage))]
    [SubTypeDiscriminator("OrderCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("OrderCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomTypeSetMessage))]
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
    [SubTypeDiscriminator("OrderPaymentRemoved", typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentRemovedMessage))]
    [SubTypeDiscriminator("OrderPaymentStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessage))]
    [SubTypeDiscriminator("OrderPurchaseOrderNumberSet", typeof(commercetools.Sdk.Api.Models.Messages.OrderPurchaseOrderNumberSetMessage))]
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
    [SubTypeDiscriminator("PaymentInterfaceIdSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentInterfaceIdSetMessage))]
    [SubTypeDiscriminator("PaymentMethodCreated", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCreatedMessage))]
    [SubTypeDiscriminator("PaymentMethodCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldAddedMessage))]
    [SubTypeDiscriminator("PaymentMethodCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldChangedMessage))]
    [SubTypeDiscriminator("PaymentMethodCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("PaymentMethodCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("PaymentMethodCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeSetMessage))]
    [SubTypeDiscriminator("PaymentMethodDefaultSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodDefaultSetMessage))]
    [SubTypeDiscriminator("PaymentMethodDeleted", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodDeletedMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldAddedMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldChangedMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeSetMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoInterfaceAccountSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceAccountSetMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoInterfaceSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceSetMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoMethodSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoMethodSetMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoNameSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoNameSetMessage))]
    [SubTypeDiscriminator("PaymentMethodInfoTokenSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoTokenSetMessage))]
    [SubTypeDiscriminator("PaymentMethodInterfaceAccountSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInterfaceAccountSetMessage))]
    [SubTypeDiscriminator("PaymentMethodKeySet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodKeySetMessage))]
    [SubTypeDiscriminator("PaymentMethodMethodSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodMethodSetMessage))]
    [SubTypeDiscriminator("PaymentMethodNameSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodNameSetMessage))]
    [SubTypeDiscriminator("PaymentMethodPaymentInterfaceSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentInterfaceSetMessage))]
    [SubTypeDiscriminator("PaymentMethodPaymentMethodStatusSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentMethodStatusSetMessage))]
    [SubTypeDiscriminator("PaymentStatusInterfaceCodeSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage))]
    [SubTypeDiscriminator("PaymentStatusStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessage))]
    [SubTypeDiscriminator("PaymentTransactionAdded", typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessage))]
    [SubTypeDiscriminator("PaymentTransactionInterfaceIdSet", typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionInterfaceIdSetMessage))]
    [SubTypeDiscriminator("PaymentTransactionStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessage))]
    [SubTypeDiscriminator("ProductAddedToCategory", typeof(commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessage))]
    [SubTypeDiscriminator("ProductCreated", typeof(commercetools.Sdk.Api.Models.Messages.ProductCreatedMessage))]
    [SubTypeDiscriminator("ProductDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductDeletedMessage))]
    [SubTypeDiscriminator("ProductImageAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessage))]
    [SubTypeDiscriminator("ProductPriceAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceAddedMessage))]
    [SubTypeDiscriminator("ProductPriceChanged", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceChangedMessage))]
    [SubTypeDiscriminator("ProductPriceCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldAddedMessage))]
    [SubTypeDiscriminator("ProductPriceCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldChangedMessage))]
    [SubTypeDiscriminator("ProductPriceCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("ProductPriceCustomFieldsRemoved", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsRemovedMessage))]
    [SubTypeDiscriminator("ProductPriceCustomFieldsSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsSetMessage))]
    [SubTypeDiscriminator("ProductPriceDiscountsSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessage))]
    [SubTypeDiscriminator("ProductPriceExternalDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessage))]
    [SubTypeDiscriminator("ProductPriceKeySet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceKeySetMessage))]
    [SubTypeDiscriminator("ProductPriceModeSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceModeSetMessage))]
    [SubTypeDiscriminator("ProductPriceRemoved", typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceRemovedMessage))]
    [SubTypeDiscriminator("ProductPricesSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductPricesSetMessage))]
    [SubTypeDiscriminator("ProductPublished", typeof(commercetools.Sdk.Api.Models.Messages.ProductPublishedMessage))]
    [SubTypeDiscriminator("ProductRemovedFromCategory", typeof(commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessage))]
    [SubTypeDiscriminator("ProductRevertedStagedChanges", typeof(commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessage))]
    [SubTypeDiscriminator("ProductSelectionCreated", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessage))]
    [SubTypeDiscriminator("ProductSelectionDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessage))]
    [SubTypeDiscriminator("ProductSelectionProductAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessage))]
    [SubTypeDiscriminator("ProductSelectionProductExcluded", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductExcludedMessage))]
    [SubTypeDiscriminator("ProductSelectionProductRemoved", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessage))]
    [SubTypeDiscriminator("ProductSelectionVariantExclusionChanged", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantExclusionChangedMessage))]
    [SubTypeDiscriminator("ProductSelectionVariantSelectionChanged", typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessage))]
    [SubTypeDiscriminator("ProductSlugChanged", typeof(commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessage))]
    [SubTypeDiscriminator("ProductStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessage))]
    [SubTypeDiscriminator("ProductTailoringCreated", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringCreatedMessage))]
    [SubTypeDiscriminator("ProductTailoringDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringDeletedMessage))]
    [SubTypeDiscriminator("ProductTailoringDescriptionSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringDescriptionSetMessage))]
    [SubTypeDiscriminator("ProductTailoringImageAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringImageAddedMessage))]
    [SubTypeDiscriminator("ProductTailoringImagesSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringImagesSetMessage))]
    [SubTypeDiscriminator("ProductTailoringNameSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringNameSetMessage))]
    [SubTypeDiscriminator("ProductTailoringPublished", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringPublishedMessage))]
    [SubTypeDiscriminator("ProductTailoringSlugSet", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringSlugSetMessage))]
    [SubTypeDiscriminator("ProductTailoringUnpublished", typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringUnpublishedMessage))]
    [SubTypeDiscriminator("ProductUnpublished", typeof(commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessage))]
    [SubTypeDiscriminator("ProductVariantAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessage))]
    [SubTypeDiscriminator("ProductVariantDeleted", typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessage))]
    [SubTypeDiscriminator("ProductVariantTailoringAdded", typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringAddedMessage))]
    [SubTypeDiscriminator("ProductVariantTailoringRemoved", typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringRemovedMessage))]
    [SubTypeDiscriminator("QuoteCreated", typeof(commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessage))]
    [SubTypeDiscriminator("QuoteCustomerChanged", typeof(commercetools.Sdk.Api.Models.Messages.QuoteCustomerChangedMessage))]
    [SubTypeDiscriminator("QuoteDeleted", typeof(commercetools.Sdk.Api.Models.Messages.QuoteDeletedMessage))]
    [SubTypeDiscriminator("QuoteRenegotiationRequested", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRenegotiationRequestedMessage))]
    [SubTypeDiscriminator("QuoteRequestCreated", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessage))]
    [SubTypeDiscriminator("QuoteRequestCustomerChanged", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestCustomerChangedMessage))]
    [SubTypeDiscriminator("QuoteRequestDeleted", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestDeletedMessage))]
    [SubTypeDiscriminator("QuoteRequestStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessage))]
    [SubTypeDiscriminator("QuoteRequestStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessage))]
    [SubTypeDiscriminator("QuoteStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessage))]
    [SubTypeDiscriminator("QuoteStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessage))]
    [SubTypeDiscriminator("RecurringOrderCreated", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCreatedMessage))]
    [SubTypeDiscriminator("RecurringOrderCustomFieldAdded", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldAddedMessage))]
    [SubTypeDiscriminator("RecurringOrderCustomFieldChanged", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldChangedMessage))]
    [SubTypeDiscriminator("RecurringOrderCustomFieldRemoved", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldRemovedMessage))]
    [SubTypeDiscriminator("RecurringOrderCustomTypeRemoved", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeRemovedMessage))]
    [SubTypeDiscriminator("RecurringOrderCustomTypeSet", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeSetMessage))]
    [SubTypeDiscriminator("RecurringOrderDeleted", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderDeletedMessage))]
    [SubTypeDiscriminator("RecurringOrderExpiresAtSet", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderExpiresAtSetMessage))]
    [SubTypeDiscriminator("RecurringOrderFailed", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderFailedMessage))]
    [SubTypeDiscriminator("RecurringOrderKeySet", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderKeySetMessage))]
    [SubTypeDiscriminator("RecurringOrderScheduleSet", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderScheduleSetMessage))]
    [SubTypeDiscriminator("RecurringOrderStartsAtSet", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderStartsAtSetMessage))]
    [SubTypeDiscriminator("RecurringOrderStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderStateChangedMessage))]
    [SubTypeDiscriminator("RecurringOrderStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderStateTransitionMessage))]
    [SubTypeDiscriminator("ReturnInfoAdded", typeof(commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessage))]
    [SubTypeDiscriminator("ReturnInfoSet", typeof(commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessage))]
    [SubTypeDiscriminator("ReviewCreated", typeof(commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessage))]
    [SubTypeDiscriminator("ReviewRatingSet", typeof(commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessage))]
    [SubTypeDiscriminator("ReviewStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessage))]
    [SubTypeDiscriminator("ShoppingListLineItemAdded", typeof(commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemAddedMessage))]
    [SubTypeDiscriminator("ShoppingListLineItemRemoved", typeof(commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemRemovedMessage))]
    [SubTypeDiscriminator("StagedQuoteCreated", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessage))]
    [SubTypeDiscriminator("StagedQuoteDeleted", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteDeletedMessage))]
    [SubTypeDiscriminator("StagedQuoteSellerCommentSet", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessage))]
    [SubTypeDiscriminator("StagedQuoteStateChanged", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessage))]
    [SubTypeDiscriminator("StagedQuoteStateTransition", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessage))]
    [SubTypeDiscriminator("StagedQuoteValidToSet", typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessage))]
    [SubTypeDiscriminator("StandalonePriceActiveChanged", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceActiveChangedMessage))]
    [SubTypeDiscriminator("StandalonePriceCreated", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessage))]
    [SubTypeDiscriminator("StandalonePriceDeleted", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessage))]
    [SubTypeDiscriminator("StandalonePriceDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessage))]
    [SubTypeDiscriminator("StandalonePriceExternalDiscountSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessage))]
    [SubTypeDiscriminator("StandalonePriceKeySet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceKeySetMessage))]
    [SubTypeDiscriminator("StandalonePriceStagedChangesApplied", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessage))]
    [SubTypeDiscriminator("StandalonePriceStagedChangesRemoved", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesRemovedMessage))]
    [SubTypeDiscriminator("StandalonePriceTierAdded", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceTierAddedMessage))]
    [SubTypeDiscriminator("StandalonePriceTierRemoved", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceTierRemovedMessage))]
    [SubTypeDiscriminator("StandalonePriceTiersSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceTiersSetMessage))]
    [SubTypeDiscriminator("StandalonePriceValidFromAndUntilSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromAndUntilSetMessage))]
    [SubTypeDiscriminator("StandalonePriceValidFromSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromSetMessage))]
    [SubTypeDiscriminator("StandalonePriceValidUntilSet", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValidUntilSetMessage))]
    [SubTypeDiscriminator("StandalonePriceValueChanged", typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessage))]
    [SubTypeDiscriminator("StoreCountriesChanged", typeof(commercetools.Sdk.Api.Models.Messages.StoreCountriesChangedMessage))]
    [SubTypeDiscriminator("StoreCreated", typeof(commercetools.Sdk.Api.Models.Messages.StoreCreatedMessage))]
    [SubTypeDiscriminator("StoreDeleted", typeof(commercetools.Sdk.Api.Models.Messages.StoreDeletedMessage))]
    [SubTypeDiscriminator("StoreDistributionChannelsChanged", typeof(commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessage))]
    [SubTypeDiscriminator("StoreLanguagesChanged", typeof(commercetools.Sdk.Api.Models.Messages.StoreLanguagesChangedMessage))]
    [SubTypeDiscriminator("StoreNameSet", typeof(commercetools.Sdk.Api.Models.Messages.StoreNameSetMessage))]
    [SubTypeDiscriminator("StoreProductSelectionsChanged", typeof(commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessage))]
    [SubTypeDiscriminator("StoreSupplyChannelsChanged", typeof(commercetools.Sdk.Api.Models.Messages.StoreSupplyChannelsChangedMessage))]
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

        static commercetools.Sdk.Api.Models.Messages.ApprovalFlowApprovedMessage ApprovalFlowApproved(Action<commercetools.Sdk.Api.Models.Messages.ApprovalFlowApprovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalFlowApprovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalFlowCompletedMessage ApprovalFlowCompleted(Action<commercetools.Sdk.Api.Models.Messages.ApprovalFlowCompletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalFlowCompletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalFlowCreatedMessage ApprovalFlowCreated(Action<commercetools.Sdk.Api.Models.Messages.ApprovalFlowCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalFlowCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalFlowRejectedMessage ApprovalFlowRejected(Action<commercetools.Sdk.Api.Models.Messages.ApprovalFlowRejectedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalFlowRejectedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalRuleApproversSetMessage ApprovalRuleApproversSet(Action<commercetools.Sdk.Api.Models.Messages.ApprovalRuleApproversSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalRuleApproversSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalRuleCreatedMessage ApprovalRuleCreated(Action<commercetools.Sdk.Api.Models.Messages.ApprovalRuleCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalRuleCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalRuleDescriptionSetMessage ApprovalRuleDescriptionSet(Action<commercetools.Sdk.Api.Models.Messages.ApprovalRuleDescriptionSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalRuleDescriptionSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalRuleKeySetMessage ApprovalRuleKeySet(Action<commercetools.Sdk.Api.Models.Messages.ApprovalRuleKeySetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalRuleKeySetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalRuleNameSetMessage ApprovalRuleNameSet(Action<commercetools.Sdk.Api.Models.Messages.ApprovalRuleNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalRuleNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalRulePredicateSetMessage ApprovalRulePredicateSet(Action<commercetools.Sdk.Api.Models.Messages.ApprovalRulePredicateSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalRulePredicateSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalRuleRequestersSetMessage ApprovalRuleRequestersSet(Action<commercetools.Sdk.Api.Models.Messages.ApprovalRuleRequestersSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalRuleRequestersSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ApprovalRuleStatusSetMessage ApprovalRuleStatusSet(Action<commercetools.Sdk.Api.Models.Messages.ApprovalRuleStatusSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ApprovalRuleStatusSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.AssociateRoleBuyerAssignableChangedMessage AssociateRoleBuyerAssignableChanged(Action<commercetools.Sdk.Api.Models.Messages.AssociateRoleBuyerAssignableChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.AssociateRoleBuyerAssignableChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.AssociateRoleCreatedMessage AssociateRoleCreated(Action<commercetools.Sdk.Api.Models.Messages.AssociateRoleCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.AssociateRoleCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.AssociateRoleDeletedMessage AssociateRoleDeleted(Action<commercetools.Sdk.Api.Models.Messages.AssociateRoleDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.AssociateRoleDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.AssociateRoleNameSetMessage AssociateRoleNameSet(Action<commercetools.Sdk.Api.Models.Messages.AssociateRoleNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.AssociateRoleNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionAddedMessage AssociateRolePermissionAdded(Action<commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionRemovedMessage AssociateRolePermissionRemoved(Action<commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionsSetMessage AssociateRolePermissionsSet(Action<commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionsSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionsSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressAddedMessage BusinessUnitAddressAdded(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressChangedMessage BusinessUnitAddressChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldAddedMessage BusinessUnitAddressCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldChangedMessage BusinessUnitAddressCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldRemovedMessage BusinessUnitAddressCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeRemovedMessage BusinessUnitAddressCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeSetMessage BusinessUnitAddressCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressRemovedMessage BusinessUnitAddressRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitApprovalRuleModeChangedMessage BusinessUnitApprovalRuleModeChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitApprovalRuleModeChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitApprovalRuleModeChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateAddedMessage BusinessUnitAssociateAdded(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateChangedMessage BusinessUnitAssociateChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateModeChangedMessage BusinessUnitAssociateModeChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateModeChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateModeChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateRemovedMessage BusinessUnitAssociateRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociatesSetMessage BusinessUnitAssociatesSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociatesSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociatesSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressAddedMessage BusinessUnitBillingAddressAdded(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressRemovedMessage BusinessUnitBillingAddressRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitContactEmailSetMessage BusinessUnitContactEmailSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitContactEmailSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitContactEmailSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCreatedMessage BusinessUnitCreated(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentAddedMessage BusinessUnitCustomerGroupAssignmentAdded(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentRemovedMessage BusinessUnitCustomerGroupAssignmentRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentsSetMessage BusinessUnitCustomerGroupAssignmentsSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentsSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentsSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldAddedMessage BusinessUnitCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldChangedMessage BusinessUnitCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldRemovedMessage BusinessUnitCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeRemovedMessage BusinessUnitCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeSetMessage BusinessUnitCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultBillingAddressSetMessage BusinessUnitDefaultBillingAddressSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultBillingAddressSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultBillingAddressSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultShippingAddressSetMessage BusinessUnitDefaultShippingAddressSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultShippingAddressSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultShippingAddressSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitDeletedMessage BusinessUnitDeleted(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitNameChangedMessage BusinessUnitNameChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitNameChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitNameChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitParentChangedMessage BusinessUnitParentChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitParentChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitParentChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitShippingAddressAddedMessage BusinessUnitShippingAddressAdded(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitShippingAddressAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitShippingAddressAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitShippingAddressRemovedMessage BusinessUnitShippingAddressRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitShippingAddressRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitShippingAddressRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitStatusChangedMessage BusinessUnitStatusChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitStatusChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitStatusChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreAddedMessage BusinessUnitStoreAdded(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreModeChangedMessage BusinessUnitStoreModeChanged(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreModeChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreModeChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreRemovedMessage BusinessUnitStoreRemoved(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitStoresSetMessage BusinessUnitStoresSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitStoresSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitStoresSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitTopLevelUnitSetMessage BusinessUnitTopLevelUnitSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitTopLevelUnitSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitTopLevelUnitSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.BusinessUnitTypeSetMessage BusinessUnitTypeSet(Action<commercetools.Sdk.Api.Models.Messages.BusinessUnitTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.BusinessUnitTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CartDiscountCreatedMessage CartDiscountCreated(Action<commercetools.Sdk.Api.Models.Messages.CartDiscountCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CartDiscountCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CartDiscountDeletedMessage CartDiscountDeleted(Action<commercetools.Sdk.Api.Models.Messages.CartDiscountDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CartDiscountDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CartDiscountStoreAddedMessage CartDiscountStoreAdded(Action<commercetools.Sdk.Api.Models.Messages.CartDiscountStoreAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CartDiscountStoreAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CartDiscountStoreRemovedMessage CartDiscountStoreRemoved(Action<commercetools.Sdk.Api.Models.Messages.CartDiscountStoreRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CartDiscountStoreRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CartDiscountStoresSetMessage CartDiscountStoresSet(Action<commercetools.Sdk.Api.Models.Messages.CartDiscountStoresSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CartDiscountStoresSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CartFrozenMessage CartFrozen(Action<commercetools.Sdk.Api.Models.Messages.CartFrozenMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CartFrozenMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CartUnfrozenMessage CartUnfrozen(Action<commercetools.Sdk.Api.Models.Messages.CartUnfrozenMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CartUnfrozenMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessage CategoryCreated(Action<commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessage CategorySlugChanged(Action<commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessage CustomerAddressAdded(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessage CustomerAddressChanged(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldAddedMessage CustomerAddressCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldChangedMessage CustomerAddressCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldRemovedMessage CustomerAddressCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeRemovedMessage CustomerAddressCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeSetMessage CustomerAddressCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessage CustomerAddressRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressAddedMessage CustomerBillingAddressAdded(Action<commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressRemovedMessage CustomerBillingAddressRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessage CustomerCompanyNameSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessage CustomerCreated(Action<commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldAddedMessage CustomerCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldChangedMessage CustomerCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldRemovedMessage CustomerCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeRemovedMessage CustomerCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeSetMessage CustomerCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessage CustomerDateOfBirthSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerDefaultBillingAddressSetMessage CustomerDefaultBillingAddressSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerDefaultBillingAddressSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerDefaultBillingAddressSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerDefaultShippingAddressSetMessage CustomerDefaultShippingAddressSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerDefaultShippingAddressSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerDefaultShippingAddressSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessage CustomerDeleted(Action<commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessage CustomerEmailChanged(Action<commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerEmailTokenCreatedMessage CustomerEmailTokenCreated(Action<commercetools.Sdk.Api.Models.Messages.CustomerEmailTokenCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerEmailTokenCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessage CustomerEmailVerified(Action<commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerEmailVerifiedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerExternalIdSetMessage CustomerExternalIdSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerExternalIdSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerExternalIdSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessage CustomerFirstNameSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentAddedMessage CustomerGroupAssignmentAdded(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentRemovedMessage CustomerGroupAssignmentRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentsSetMessage CustomerGroupAssignmentsSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentsSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentsSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldAddedMessage CustomerGroupCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldChangedMessage CustomerGroupCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldRemovedMessage CustomerGroupCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeRemovedMessage CustomerGroupCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeSetMessage CustomerGroupCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessage CustomerGroupSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerGroupSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessage CustomerLastNameSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerPasswordTokenCreatedMessage CustomerPasswordTokenCreated(Action<commercetools.Sdk.Api.Models.Messages.CustomerPasswordTokenCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerPasswordTokenCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessage CustomerPasswordUpdated(Action<commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerShippingAddressAddedMessage CustomerShippingAddressAdded(Action<commercetools.Sdk.Api.Models.Messages.CustomerShippingAddressAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerShippingAddressAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerShippingAddressRemovedMessage CustomerShippingAddressRemoved(Action<commercetools.Sdk.Api.Models.Messages.CustomerShippingAddressRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerShippingAddressRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerStoresSetMessage CustomerStoresSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerStoresSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerStoresSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessage CustomerTitleSet(Action<commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessage CustomLineItemStateTransition(Action<commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessage DeliveryAdded(Action<commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessage DeliveryAddressSet(Action<commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldAddedMessage DeliveryCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldChangedMessage DeliveryCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldRemovedMessage DeliveryCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeRemovedMessage DeliveryCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeSetMessage DeliveryCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessage DeliveryItemsUpdated(Action<commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessage DeliveryRemoved(Action<commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DiscountCodeCreatedMessage DiscountCodeCreated(Action<commercetools.Sdk.Api.Models.Messages.DiscountCodeCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DiscountCodeCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DiscountCodeDeletedMessage DiscountCodeDeleted(Action<commercetools.Sdk.Api.Models.Messages.DiscountCodeDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DiscountCodeDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DiscountCodeKeySetMessage DiscountCodeKeySet(Action<commercetools.Sdk.Api.Models.Messages.DiscountCodeKeySetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DiscountCodeKeySetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DiscountGroupCreatedMessage DiscountGroupCreated(Action<commercetools.Sdk.Api.Models.Messages.DiscountGroupCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DiscountGroupCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DiscountGroupDeletedMessage DiscountGroupDeleted(Action<commercetools.Sdk.Api.Models.Messages.DiscountGroupDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DiscountGroupDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DiscountGroupIsActiveSetMessage DiscountGroupIsActiveSet(Action<commercetools.Sdk.Api.Models.Messages.DiscountGroupIsActiveSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DiscountGroupIsActiveSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DiscountGroupKeySetMessage DiscountGroupKeySet(Action<commercetools.Sdk.Api.Models.Messages.DiscountGroupKeySetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DiscountGroupKeySetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.DiscountGroupSortOrderSetMessage DiscountGroupSortOrderSet(Action<commercetools.Sdk.Api.Models.Messages.DiscountGroupSortOrderSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.DiscountGroupSortOrderSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessage InventoryEntryCreated(Action<commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessage InventoryEntryDeleted(Action<commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessage InventoryEntryQuantitySet(Action<commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessage LineItemStateTransition(Action<commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessage OrderBillingAddressSet(Action<commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderBusinessUnitSetMessage OrderBusinessUnitSet(Action<commercetools.Sdk.Api.Models.Messages.OrderBusinessUnitSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderBusinessUnitSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCreatedMessage OrderCreated(Action<commercetools.Sdk.Api.Models.Messages.OrderCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCreatedFromRecurringOrderMessage OrderCreatedFromRecurringOrder(Action<commercetools.Sdk.Api.Models.Messages.OrderCreatedFromRecurringOrderMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCreatedFromRecurringOrderMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessage OrderCustomerEmailSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessage OrderCustomerGroupSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomerGroupSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessage OrderCustomerSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomFieldAddedMessage OrderCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomFieldChangedMessage OrderCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomFieldRemovedMessage OrderCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessage OrderCustomLineItemAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage OrderCustomLineItemDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessage OrderCustomLineItemQuantityChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessage OrderCustomLineItemRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomTypeRemovedMessage OrderCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderCustomTypeSetMessage OrderCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.OrderCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderDeletedMessage OrderDeleted(Action<commercetools.Sdk.Api.Models.Messages.OrderDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessage OrderDiscountCodeAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessage OrderDiscountCodeRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessage OrderDiscountCodeStateSet(Action<commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessage OrderEditApplied(Action<commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderImportedMessage OrderImported(Action<commercetools.Sdk.Api.Models.Messages.OrderImportedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderImportedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessage OrderLineItemAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessage OrderLineItemDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessage OrderLineItemDistributionChannelSet(Action<commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessage OrderLineItemRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessage OrderPaymentAdded(Action<commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderPaymentRemovedMessage OrderPaymentRemoved(Action<commercetools.Sdk.Api.Models.Messages.OrderPaymentRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderPaymentRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessage OrderPaymentStateChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderPurchaseOrderNumberSetMessage OrderPurchaseOrderNumberSet(Action<commercetools.Sdk.Api.Models.Messages.OrderPurchaseOrderNumberSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderPurchaseOrderNumberSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessage OrderReturnShipmentStateChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessage OrderShipmentStateChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessage OrderShippingAddressSet(Action<commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessage OrderShippingInfoSet(Action<commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessage OrderShippingRateInputSet(Action<commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessage OrderStateChanged(Action<commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderStateTransitionMessage OrderStateTransition(Action<commercetools.Sdk.Api.Models.Messages.OrderStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessage OrderStoreSet(Action<commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessage ParcelAddedToDelivery(Action<commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessage ParcelItemsUpdated(Action<commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessage ParcelMeasurementsUpdated(Action<commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessage ParcelRemovedFromDelivery(Action<commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessage ParcelTrackingDataUpdated(Action<commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessage PaymentCreated(Action<commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessage PaymentInteractionAdded(Action<commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentInterfaceIdSetMessage PaymentInterfaceIdSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentInterfaceIdSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentInterfaceIdSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodCreatedMessage PaymentMethodCreated(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldAddedMessage PaymentMethodCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldChangedMessage PaymentMethodCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldRemovedMessage PaymentMethodCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeRemovedMessage PaymentMethodCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeSetMessage PaymentMethodCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodDefaultSetMessage PaymentMethodDefaultSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodDefaultSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodDefaultSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodDeletedMessage PaymentMethodDeleted(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldAddedMessage PaymentMethodInfoCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldChangedMessage PaymentMethodInfoCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldRemovedMessage PaymentMethodInfoCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeRemovedMessage PaymentMethodInfoCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeSetMessage PaymentMethodInfoCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceAccountSetMessage PaymentMethodInfoInterfaceAccountSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceAccountSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceAccountSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceSetMessage PaymentMethodInfoInterfaceSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoMethodSetMessage PaymentMethodInfoMethodSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoMethodSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoMethodSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoNameSetMessage PaymentMethodInfoNameSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoTokenSetMessage PaymentMethodInfoTokenSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoTokenSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoTokenSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodInterfaceAccountSetMessage PaymentMethodInterfaceAccountSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodInterfaceAccountSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodInterfaceAccountSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodKeySetMessage PaymentMethodKeySet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodKeySetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodKeySetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodMethodSetMessage PaymentMethodMethodSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodMethodSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodMethodSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodNameSetMessage PaymentMethodNameSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentInterfaceSetMessage PaymentMethodPaymentInterfaceSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentInterfaceSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentInterfaceSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentMethodStatusSetMessage PaymentMethodPaymentMethodStatusSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentMethodStatusSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentMethodStatusSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage PaymentStatusInterfaceCodeSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessage PaymentStatusStateTransition(Action<commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessage PaymentTransactionAdded(Action<commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentTransactionInterfaceIdSetMessage PaymentTransactionInterfaceIdSet(Action<commercetools.Sdk.Api.Models.Messages.PaymentTransactionInterfaceIdSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentTransactionInterfaceIdSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessage PaymentTransactionStateChanged(Action<commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessage ProductAddedToCategory(Action<commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductCreatedMessage ProductCreated(Action<commercetools.Sdk.Api.Models.Messages.ProductCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductDeletedMessage ProductDeleted(Action<commercetools.Sdk.Api.Models.Messages.ProductDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessage ProductImageAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceAddedMessage ProductPriceAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceChangedMessage ProductPriceChanged(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldAddedMessage ProductPriceCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldChangedMessage ProductPriceCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldRemovedMessage ProductPriceCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsRemovedMessage ProductPriceCustomFieldsRemoved(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsSetMessage ProductPriceCustomFieldsSet(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessage ProductPriceDiscountsSet(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessage ProductPriceExternalDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceKeySetMessage ProductPriceKeySet(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceKeySetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceKeySetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceModeSetMessage ProductPriceModeSet(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceModeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceModeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPriceRemovedMessage ProductPriceRemoved(Action<commercetools.Sdk.Api.Models.Messages.ProductPriceRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPriceRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPricesSetMessage ProductPricesSet(Action<commercetools.Sdk.Api.Models.Messages.ProductPricesSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPricesSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductPublishedMessage ProductPublished(Action<commercetools.Sdk.Api.Models.Messages.ProductPublishedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductPublishedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessage ProductRemovedFromCategory(Action<commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductRemovedFromCategoryMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessage ProductRevertedStagedChanges(Action<commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessage ProductSelectionCreated(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessage ProductSelectionDeleted(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessage ProductSelectionProductAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionProductExcludedMessage ProductSelectionProductExcluded(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionProductExcludedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionProductExcludedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessage ProductSelectionProductRemoved(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantExclusionChangedMessage ProductSelectionVariantExclusionChanged(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantExclusionChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantExclusionChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessage ProductSelectionVariantSelectionChanged(Action<commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessage ProductSlugChanged(Action<commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessage ProductStateTransition(Action<commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringCreatedMessage ProductTailoringCreated(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringDeletedMessage ProductTailoringDeleted(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringDescriptionSetMessage ProductTailoringDescriptionSet(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringDescriptionSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringDescriptionSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringImageAddedMessage ProductTailoringImageAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringImageAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringImageAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringImagesSetMessage ProductTailoringImagesSet(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringImagesSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringImagesSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringNameSetMessage ProductTailoringNameSet(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringPublishedMessage ProductTailoringPublished(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringPublishedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringPublishedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringSlugSetMessage ProductTailoringSlugSet(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringSlugSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringSlugSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductTailoringUnpublishedMessage ProductTailoringUnpublished(Action<commercetools.Sdk.Api.Models.Messages.ProductTailoringUnpublishedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductTailoringUnpublishedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessage ProductUnpublished(Action<commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductUnpublishedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessage ProductVariantAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessage ProductVariantDeleted(Action<commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringAddedMessage ProductVariantTailoringAdded(Action<commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringRemovedMessage ProductVariantTailoringRemoved(Action<commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessage QuoteCreated(Action<commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteCustomerChangedMessage QuoteCustomerChanged(Action<commercetools.Sdk.Api.Models.Messages.QuoteCustomerChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteCustomerChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteDeletedMessage QuoteDeleted(Action<commercetools.Sdk.Api.Models.Messages.QuoteDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRenegotiationRequestedMessage QuoteRenegotiationRequested(Action<commercetools.Sdk.Api.Models.Messages.QuoteRenegotiationRequestedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRenegotiationRequestedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessage QuoteRequestCreated(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestCustomerChangedMessage QuoteRequestCustomerChanged(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestCustomerChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestCustomerChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestDeletedMessage QuoteRequestDeleted(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessage QuoteRequestStateChanged(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessage QuoteRequestStateTransition(Action<commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessage QuoteStateChanged(Action<commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessage QuoteStateTransition(Action<commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderCreatedMessage RecurringOrderCreated(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldAddedMessage RecurringOrderCustomFieldAdded(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldChangedMessage RecurringOrderCustomFieldChanged(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldRemovedMessage RecurringOrderCustomFieldRemoved(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeRemovedMessage RecurringOrderCustomTypeRemoved(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeSetMessage RecurringOrderCustomTypeSet(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderDeletedMessage RecurringOrderDeleted(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderExpiresAtSetMessage RecurringOrderExpiresAtSet(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderExpiresAtSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderExpiresAtSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderFailedMessage RecurringOrderFailed(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderFailedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderFailedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderKeySetMessage RecurringOrderKeySet(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderKeySetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderKeySetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderScheduleSetMessage RecurringOrderScheduleSet(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderScheduleSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderScheduleSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderStartsAtSetMessage RecurringOrderStartsAtSet(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderStartsAtSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderStartsAtSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderStateChangedMessage RecurringOrderStateChanged(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.RecurringOrderStateTransitionMessage RecurringOrderStateTransition(Action<commercetools.Sdk.Api.Models.Messages.RecurringOrderStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.RecurringOrderStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessage ReturnInfoAdded(Action<commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessage ReturnInfoSet(Action<commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessage ReviewCreated(Action<commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessage ReviewRatingSet(Action<commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessage ReviewStateTransition(Action<commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemAddedMessage ShoppingListLineItemAdded(Action<commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemRemovedMessage ShoppingListLineItemRemoved(Action<commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessage StagedQuoteCreated(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteDeletedMessage StagedQuoteDeleted(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessage StagedQuoteSellerCommentSet(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessage StagedQuoteStateChanged(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessage StagedQuoteStateTransition(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessage StagedQuoteValidToSet(Action<commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceActiveChangedMessage StandalonePriceActiveChanged(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceActiveChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceActiveChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessage StandalonePriceCreated(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessage StandalonePriceDeleted(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessage StandalonePriceDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessage StandalonePriceExternalDiscountSet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceKeySetMessage StandalonePriceKeySet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceKeySetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceKeySetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessage StandalonePriceStagedChangesApplied(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesRemovedMessage StandalonePriceStagedChangesRemoved(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceTierAddedMessage StandalonePriceTierAdded(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceTierAddedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceTierAddedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceTierRemovedMessage StandalonePriceTierRemoved(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceTierRemovedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceTierRemovedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceTiersSetMessage StandalonePriceTiersSet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceTiersSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceTiersSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromAndUntilSetMessage StandalonePriceValidFromAndUntilSet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromAndUntilSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromAndUntilSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromSetMessage StandalonePriceValidFromSet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceValidUntilSetMessage StandalonePriceValidUntilSet(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceValidUntilSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceValidUntilSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessage StandalonePriceValueChanged(Action<commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreCountriesChangedMessage StoreCountriesChanged(Action<commercetools.Sdk.Api.Models.Messages.StoreCountriesChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreCountriesChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreCreatedMessage StoreCreated(Action<commercetools.Sdk.Api.Models.Messages.StoreCreatedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreCreatedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreDeletedMessage StoreDeleted(Action<commercetools.Sdk.Api.Models.Messages.StoreDeletedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreDeletedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessage StoreDistributionChannelsChanged(Action<commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreLanguagesChangedMessage StoreLanguagesChanged(Action<commercetools.Sdk.Api.Models.Messages.StoreLanguagesChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreLanguagesChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreNameSetMessage StoreNameSet(Action<commercetools.Sdk.Api.Models.Messages.StoreNameSetMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreNameSetMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessage StoreProductSelectionsChanged(Action<commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessage();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Messages.StoreSupplyChannelsChangedMessage StoreSupplyChannelsChanged(Action<commercetools.Sdk.Api.Models.Messages.StoreSupplyChannelsChangedMessage> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Messages.StoreSupplyChannelsChangedMessage();
            init?.Invoke(t);
            return t;
        }
    }
}
