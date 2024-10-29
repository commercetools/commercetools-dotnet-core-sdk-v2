using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleQueryBuilderDsl
    {
        public ApprovalRuleQueryBuilderDsl()
        {
        }

        public static ApprovalRuleQueryBuilderDsl Of()
        {
            return new ApprovalRuleQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ApprovalRuleQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ApprovalRuleQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl> Approvers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("approvers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl.Of())),
                ApprovalRuleQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl> Requesters(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("requesters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl.Of())),
                ApprovalRuleQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRuleQueryBuilderDsl> Requesters()
        {
            return new CollectionPredicateBuilder<ApprovalRuleQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requesters")),
                    p => new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(p, ApprovalRuleQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                ApprovalRuleQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ApprovalRuleQueryBuilderDsl.Of);
        }


    }
}
