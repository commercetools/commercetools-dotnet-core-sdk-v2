using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApproverHierarchyDraftQueryBuilderDsl
    {
        public ApproverHierarchyDraftQueryBuilderDsl()
        {
        }

        public static ApproverHierarchyDraftQueryBuilderDsl Of()
        {
            return new ApproverHierarchyDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ApproverHierarchyDraftQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverConjunctionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverConjunctionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApproverHierarchyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverConjunctionDraftQueryBuilderDsl.Of())),
                ApproverHierarchyDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApproverHierarchyDraftQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<ApproverHierarchyDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<ApproverHierarchyDraftQueryBuilderDsl>(p, ApproverHierarchyDraftQueryBuilderDsl.Of));
        }

    }
}
