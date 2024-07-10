using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApproverDisjunctionQueryBuilderDsl
    {
        public ApproverDisjunctionQueryBuilderDsl()
        {
        }

        public static ApproverDisjunctionQueryBuilderDsl Of()
        {
            return new ApproverDisjunctionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ApproverDisjunctionQueryBuilderDsl> Or(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApproverDisjunctionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("or"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleApproverQueryBuilderDsl.Of())),
                ApproverDisjunctionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApproverDisjunctionQueryBuilderDsl> Or()
        {
            return new CollectionPredicateBuilder<ApproverDisjunctionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("or")),
                    p => new CombinationQueryPredicate<ApproverDisjunctionQueryBuilderDsl>(p, ApproverDisjunctionQueryBuilderDsl.Of));
        }

    }
}
