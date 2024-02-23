using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowQueryBuilderDsl
    {
        public ApprovalFlowQueryBuilderDsl()
        {
        }

        public static ApprovalFlowQueryBuilderDsl Of()
        {
            return new ApprovalFlowQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> Rules(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("rules"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl> Rules()
        {
            return new CollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rules")),
                    p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> Rejection(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowRejectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowRejectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("rejection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowRejectionQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> Approvals(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowApprovalQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowApprovalQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("approvals"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowApprovalQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl> Approvals()
        {
            return new CollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("approvals")),
                    p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> EligibleApprovers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("eligibleApprovers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl> EligibleApprovers()
        {
            return new CollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("eligibleApprovers")),
                    p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> PendingApprovers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("pendingApprovers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl> PendingApprovers()
        {
            return new CollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("pendingApprovers")),
                    p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> CurrentTierPendingApprovers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("currentTierPendingApprovers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl> CurrentTierPendingApprovers()
        {
            return new CollectionPredicateBuilder<ApprovalFlowQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currentTierPendingApprovers")),
                    p => new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(p, ApprovalFlowQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ApprovalFlowQueryBuilderDsl.Of);
        }


    }
}
