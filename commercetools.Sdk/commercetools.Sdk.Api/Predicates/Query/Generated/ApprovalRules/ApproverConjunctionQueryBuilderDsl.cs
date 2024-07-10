using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApproverConjunctionQueryBuilderDsl
    {
        public ApproverConjunctionQueryBuilderDsl()
        {
        }

        public static ApproverConjunctionQueryBuilderDsl Of()
        {
            return new ApproverConjunctionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ApproverConjunctionQueryBuilderDsl> And(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverDisjunctionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverDisjunctionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApproverConjunctionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("and"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverDisjunctionQueryBuilderDsl.Of())),
                ApproverConjunctionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApproverConjunctionQueryBuilderDsl> And()
        {
            return new CollectionPredicateBuilder<ApproverConjunctionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("and")),
                    p => new CombinationQueryPredicate<ApproverConjunctionQueryBuilderDsl>(p, ApproverConjunctionQueryBuilderDsl.Of));
        }

    }
}
