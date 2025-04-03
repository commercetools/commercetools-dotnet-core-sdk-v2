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

        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalFlowApproved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowApprovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowApprovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowApprovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalFlowCompleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowCompletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowCompletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowCompletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalFlowCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalFlowRejected(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowRejectedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowRejectedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalFlowRejectedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalRuleApproversSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalRuleCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalRuleDescriptionSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalRuleKeySet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleKeySetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleKeySetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleKeySetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalRuleNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleNameSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleNameSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleNameSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalRulePredicateSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalRuleRequestersSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsApprovalRuleStatusSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
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
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.AssociateRoleNameSetMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomTypeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomTypeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressCustomTypeSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitAddressRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitAddressRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitApprovalRuleModeChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomTypeRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomTypeRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitParentChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitParentChangedMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitTopLevelUnitSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitTopLevelUnitSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsBusinessUnitTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitTypeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitTypeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.BusinessUnitTypeSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCartDiscountCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCartDiscountDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCartDiscountStoreAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoreAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoreAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoreAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCartDiscountStoreRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCartDiscountStoresSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoresSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoresSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CartDiscountStoresSetMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerAddressCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerAddressCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerAddressCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerAddressCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerAddressCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerCustomTypeSetMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerEmailTokenCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupAssignmentAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupAssignmentRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupAssignmentsSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerGroupCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsCustomerPasswordTokenCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsDiscountCodeCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsDiscountCodeDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsDiscountCodeKeySet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeKeySetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeKeySetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DiscountCodeKeySetMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldChangedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceCustomFieldsRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductPriceCustomFieldsSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldsSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldsSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceCustomFieldsSetMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringCreatedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringDeletedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringDescriptionSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringDescriptionSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringDescriptionSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringDescriptionSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringImageAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringImageAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringImageAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringImageAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringImagesSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringImagesSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringImagesSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringImagesSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringNameSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringNameSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringNameSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringNameSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringPublished(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringPublishedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringPublishedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringPublishedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringSlugSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringSlugSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringSlugSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringSlugSetMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductTailoringUnpublished(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringUnpublishedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringUnpublishedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductTailoringUnpublishedMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductVariantTailoringAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl.Of()),
                MessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsProductVariantTailoringRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantTailoringRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantTailoringRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductVariantTailoringRemovedMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsQuoteRenegotiationRequested(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsShoppingListMessagePayload(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListMessagePayloadQueryBuilderDsl.Of()),
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
        public CombinationQueryPredicate<MessagePayloadQueryBuilderDsl> AsStandalonePriceStagedChangesRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl.Of()),
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
