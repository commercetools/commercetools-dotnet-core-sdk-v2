using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class MessagePayloadQueryBuilderDsl
    {
        public MessagePayloadQueryBuilderDsl()
        {
        }

        public static MessagePayloadQueryBuilderDsl Of()
        {
            return new MessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<MessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(p, MessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsAssociateRoleBuyerAssignableChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsAssociateRoleCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsAssociateRoleDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsAssociateRoleNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsAssociateRolePermissionAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsAssociateRolePermissionRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsAssociateRolePermissionsSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAssociateAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAssociateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAssociateModeChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAssociateRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAssociatesSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociatesSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitBillingAddressAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitBillingAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitContactEmailSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitContactEmailSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitDefaultBillingAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitDefaultShippingAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitNameChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitNameChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitNameChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitNameChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitParentUnitChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentUnitChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentUnitChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentUnitChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitShippingAddressAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitShippingAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitStatusChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitStoreAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitStoreModeChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitStoreRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitStoresSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoresSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoresSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoresSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCategoryCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CategoryCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CategoryCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CategoryCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCategorySlugChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CategorySlugChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CategorySlugChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CategorySlugChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerAddressAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerAddressChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerCompanyNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCompanyNameSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCompanyNameSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCompanyNameSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerDateOfBirthSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerEmailChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerEmailVerified(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailVerifiedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailVerifiedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailVerifiedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerFirstNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerFirstNameSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerFirstNameSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerFirstNameSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerLastNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerLastNameSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerLastNameSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerLastNameSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerPasswordUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerTitleSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerTitleSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerTitleSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerTitleSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsInventoryEntryCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsInventoryEntryDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsInventoryEntryQuantitySet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsOrderMessagePayload(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsOrderPaymentAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsPaymentCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsPaymentInteractionAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentInteractionAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentInteractionAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentInteractionAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsPaymentStatusInterfaceCodeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsPaymentStatusStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsPaymentTransactionAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsPaymentTransactionStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductAddedToCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductAddedToCategoryMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductAddedToCategoryMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductAddedToCategoryMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductImageAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductImageAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductImageAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductImageAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceDiscountsSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceExternalDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceKeySet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceKeySetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceKeySetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceKeySetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceModeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceModeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceModeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceModeSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPricesSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPricesSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPricesSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPricesSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPublished(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPublishedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPublishedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPublishedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductRemovedFromCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductRevertedStagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductSelectionCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductSelectionDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductSelectionProductAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductSelectionProductExcluded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductExcludedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductExcludedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductExcludedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductSelectionProductRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductSelectionVariantExclusionChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductSelectionVariantSelectionChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductSlugChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSlugChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSlugChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSlugChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductUnpublished(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductUnpublishedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductUnpublishedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductUnpublishedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductVariantAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductVariantDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteCustomerChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCustomerChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCustomerChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCustomerChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteRequestCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteRequestCustomerChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteRequestDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteRequestStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteRequestStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsReviewCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReviewCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsReviewRatingSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewRatingSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewRatingSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReviewRatingSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsReviewStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReviewStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsShoppingListStoreSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListStoreSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListStoreSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListStoreSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStagedQuoteCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStagedQuoteDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStagedQuoteSellerCommentSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStagedQuoteStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStagedQuoteStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStagedQuoteValidToSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteValidToSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteValidToSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteValidToSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceActiveChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDiscountSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDiscountSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDiscountSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceExternalDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceKeySet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceKeySetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceKeySetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceKeySetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceStagedChangesApplied(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceTierAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceTierRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceTiersSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTiersSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTiersSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTiersSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceValidFromAndUntilSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceValidFromSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceValidUntilSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceValueChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValueChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValueChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValueChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStoreCountriesChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreCountriesChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreCountriesChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreCountriesChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStoreCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStoreDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStoreDistributionChannelsChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStoreLanguagesChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreLanguagesChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreLanguagesChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreLanguagesChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStoreNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreNameSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreNameSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreNameSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStoreProductSelectionsChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStoreSupplyChannelsChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
    }
}
