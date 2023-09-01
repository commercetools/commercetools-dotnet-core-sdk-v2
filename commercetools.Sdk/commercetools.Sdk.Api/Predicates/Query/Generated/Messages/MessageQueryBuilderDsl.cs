using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class MessageQueryBuilderDsl
    {
        public MessageQueryBuilderDsl()
        {
        }

        public static MessageQueryBuilderDsl Of()
        {
            return new MessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<MessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<MessageQueryBuilderDsl>(p, MessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MessageQueryBuilderDsl>(p, MessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<MessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<MessageQueryBuilderDsl>(p, MessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<MessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<MessageQueryBuilderDsl>(p, MessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                MessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                MessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<MessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<MessageQueryBuilderDsl>(p, MessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                MessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<MessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<MessageQueryBuilderDsl>(p, MessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<MessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<MessageQueryBuilderDsl>(p, MessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                MessageQueryBuilderDsl.Of);
        }


        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsAssociateRoleBuyerAssignableChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsAssociateRoleCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsAssociateRoleDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsAssociateRoleNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsAssociateRolePermissionAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsAssociateRolePermissionRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsAssociateRolePermissionsSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionsSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionsSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRolePermissionsSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitAddressAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitAddressChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitAssociateAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitAssociateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitAssociateModeChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateModeChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateModeChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateModeChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitAssociateRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociateRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitAssociatesSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociatesSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociatesSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAssociatesSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitBillingAddressAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitBillingAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitBillingAddressRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitContactEmailSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitContactEmailSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitContactEmailSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitContactEmailSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitDefaultBillingAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultBillingAddressSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultBillingAddressSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultBillingAddressSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitDefaultShippingAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultShippingAddressSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultShippingAddressSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDefaultShippingAddressSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitNameChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitNameChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitNameChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitNameChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitParentChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitShippingAddressAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitShippingAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitShippingAddressRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitStatusChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStatusChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStatusChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStatusChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitStoreAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitStoreModeChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreModeChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreModeChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitStoreRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoreRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsBusinessUnitStoresSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoresSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoresSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitStoresSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCategoryCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CategoryCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CategoryCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CategoryCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCategorySlugChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CategorySlugChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CategorySlugChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CategorySlugChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerAddressAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerAddressChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerAddressCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerAddressCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerAddressCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerAddressCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerAddressCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerCompanyNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCompanyNameSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCompanyNameSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCompanyNameSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerDateOfBirthSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDateOfBirthSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDateOfBirthSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDateOfBirthSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerEmailChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerEmailVerified(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailVerifiedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailVerifiedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailVerifiedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerFirstNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerFirstNameSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerFirstNameSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerFirstNameSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerGroupSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerLastNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerLastNameSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerLastNameSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerLastNameSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerPasswordUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordUpdatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordUpdatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordUpdatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsCustomerTitleSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerTitleSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerTitleSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerTitleSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsInventoryEntryCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsInventoryEntryDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsInventoryEntryQuantitySet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryQuantitySetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryQuantitySetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.InventoryEntryQuantitySetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsOrderMessage(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsOrderPaymentAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsPaymentCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsPaymentInteractionAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentInteractionAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentInteractionAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentInteractionAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsPaymentStatusInterfaceCodeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsPaymentStatusStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentStatusStateTransitionMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsPaymentTransactionAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsPaymentTransactionStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionStateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionStateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.PaymentTransactionStateChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductAddedToCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductAddedToCategoryMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductAddedToCategoryMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductAddedToCategoryMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductImageAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductImageAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductImageAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductImageAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPriceAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPriceChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPriceDiscountsSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPriceExternalDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceExternalDiscountSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceExternalDiscountSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceExternalDiscountSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPriceKeySet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceKeySetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceKeySetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceKeySetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPriceModeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceModeSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceModeSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceModeSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPriceRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPricesSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPricesSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPricesSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPricesSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductPublished(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPublishedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPublishedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPublishedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductRemovedFromCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductRemovedFromCategoryMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductRemovedFromCategoryMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductRemovedFromCategoryMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductRevertedStagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductRevertedStagedChangesMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductRevertedStagedChangesMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductRevertedStagedChangesMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductSelectionCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductSelectionDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductSelectionProductAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductSelectionProductExcluded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductExcludedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductExcludedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductExcludedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductSelectionProductRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionProductRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductSelectionVariantExclusionChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantExclusionChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantExclusionChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantExclusionChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductSelectionVariantSelectionChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductSlugChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSlugChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductSlugChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductSlugChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductStateTransitionMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductUnpublished(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductUnpublishedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductUnpublishedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductUnpublishedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductVariantAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsProductVariantDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteCustomerChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCustomerChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCustomerChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteCustomerChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteRenegotiationRequested(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRenegotiationRequestedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRenegotiationRequestedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteRequestCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteRequestCustomerChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCustomerChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCustomerChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestCustomerChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteRequestDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteRequestStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteRequestStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRequestStateTransitionMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsQuoteStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteStateTransitionMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsReviewCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReviewCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsReviewRatingSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewRatingSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewRatingSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReviewRatingSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsReviewStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReviewStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReviewStateTransitionMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStagedQuoteCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStagedQuoteDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStagedQuoteSellerCommentSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteSellerCommentSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteSellerCommentSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteSellerCommentSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStagedQuoteStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStagedQuoteStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteStateTransitionMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStagedQuoteValidToSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteValidToSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteValidToSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StagedQuoteValidToSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceActiveChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceActiveChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceActiveChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceActiveChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDiscountSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDiscountSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceDiscountSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceExternalDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceKeySet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceKeySetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceKeySetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceKeySetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceStagedChangesApplied(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceStagedChangesRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceTierAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierAddedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceTierRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTierRemovedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceTiersSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTiersSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTiersSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceTiersSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceValidFromAndUntilSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromAndUntilSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromAndUntilSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromAndUntilSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceValidFromSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidFromSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceValidUntilSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidUntilSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidUntilSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValidUntilSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStandalonePriceValueChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValueChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValueChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceValueChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStoreCountriesChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreCountriesChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreCountriesChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreCountriesChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStoreCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreCreatedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStoreDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreDeletedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStoreDistributionChannelsChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreDistributionChannelsChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreDistributionChannelsChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStoreLanguagesChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreLanguagesChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreLanguagesChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreLanguagesChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStoreNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreNameSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreNameSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreNameSetMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStoreProductSelectionsChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreProductSelectionsChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreProductSelectionsChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreProductSelectionsChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessageQueryBuilderDsl> AsStoreSupplyChannelsChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StoreSupplyChannelsChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StoreSupplyChannelsChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of()),
                MessageQueryBuilderDsl.Of);
        }
    }
}
