using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApproverHierarchyQueryBuilderDsl
    {
        public ApproverHierarchyQueryBuilderDsl()
        {
        }

        public static ApproverHierarchyQueryBuilderDsl Of()
        {
            return new ApproverHierarchyQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ApproverHierarchyQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverConjunctionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverConjunctionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApproverHierarchyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverConjunctionQueryBuilderDsl.Of())),
                ApproverHierarchyQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApproverHierarchyQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<ApproverHierarchyQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<ApproverHierarchyQueryBuilderDsl>(p, ApproverHierarchyQueryBuilderDsl.Of));
        }

    }
}
