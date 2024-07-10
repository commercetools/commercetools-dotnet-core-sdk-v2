using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApproverDisjunctionDraftQueryBuilderDsl
    {
        public ApproverDisjunctionDraftQueryBuilderDsl()
        {
        }

        public static ApproverDisjunctionDraftQueryBuilderDsl Of()
        {
            return new ApproverDisjunctionDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ApproverDisjunctionDraftQueryBuilderDsl> Or(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApproverDisjunctionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("or"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverDraftQueryBuilderDsl.Of())),
                ApproverDisjunctionDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApproverDisjunctionDraftQueryBuilderDsl> Or()
        {
            return new CollectionPredicateBuilder<ApproverDisjunctionDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("or")),
                    p => new CombinationQueryPredicate<ApproverDisjunctionDraftQueryBuilderDsl>(p, ApproverDisjunctionDraftQueryBuilderDsl.Of));
        }

    }
}
