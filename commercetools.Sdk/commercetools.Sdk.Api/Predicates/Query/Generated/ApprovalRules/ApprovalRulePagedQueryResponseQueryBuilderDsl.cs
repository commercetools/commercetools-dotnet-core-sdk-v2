using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRulePagedQueryResponseQueryBuilderDsl
    {
        public ApprovalRulePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ApprovalRulePagedQueryResponseQueryBuilderDsl Of()
        {
            return new ApprovalRulePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ApprovalRulePagedQueryResponseQueryBuilderDsl>(p, ApprovalRulePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ApprovalRulePagedQueryResponseQueryBuilderDsl>(p, ApprovalRulePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ApprovalRulePagedQueryResponseQueryBuilderDsl>(p, ApprovalRulePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ApprovalRulePagedQueryResponseQueryBuilderDsl>(p, ApprovalRulePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRulePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRulePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl.Of())),
                ApprovalRulePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ApprovalRulePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ApprovalRulePagedQueryResponseQueryBuilderDsl>(p, ApprovalRulePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
