using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApproverConjunctionDraftQueryBuilderDsl
    {
        public ApproverConjunctionDraftQueryBuilderDsl()
        {
        }

        public static ApproverConjunctionDraftQueryBuilderDsl Of()
        {
            return new ApproverConjunctionDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ApproverConjunctionDraftQueryBuilderDsl> And(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverDisjunctionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverDisjunctionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApproverConjunctionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("and"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverDisjunctionDraftQueryBuilderDsl.Of())),
                ApproverConjunctionDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApproverConjunctionDraftQueryBuilderDsl> And()
        {
            return new CollectionPredicateBuilder<ApproverConjunctionDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("and")),
                    p => new CombinationQueryPredicate<ApproverConjunctionDraftQueryBuilderDsl>(p, ApproverConjunctionDraftQueryBuilderDsl.Of));
        }

    }
}
