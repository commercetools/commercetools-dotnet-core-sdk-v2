using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleDraftQueryBuilderDsl
    {
        public ApprovalRuleDraftQueryBuilderDsl()
        {
        }

        public static ApprovalRuleDraftQueryBuilderDsl Of()
        {
            return new ApprovalRuleDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl>(p, ApprovalRuleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl>(p, ApprovalRuleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl>(p, ApprovalRuleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl>(p, ApprovalRuleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl>(p, ApprovalRuleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl> Approvers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("approvers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyDraftQueryBuilderDsl.Of())),
                ApprovalRuleDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl> Requesters(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("requesters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterDraftQueryBuilderDsl.Of())),
                ApprovalRuleDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl> Requesters()
        {
            return new CollectionPredicateBuilder<ApprovalRuleDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requesters")),
                    p => new CombinationQueryPredicate<ApprovalRuleDraftQueryBuilderDsl>(p, ApprovalRuleDraftQueryBuilderDsl.Of));
        }

    }
}
