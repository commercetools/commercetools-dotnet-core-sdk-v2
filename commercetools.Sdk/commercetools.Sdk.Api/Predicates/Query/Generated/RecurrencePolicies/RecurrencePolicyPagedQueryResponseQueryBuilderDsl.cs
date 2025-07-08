using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicyPagedQueryResponseQueryBuilderDsl
    {
        public RecurrencePolicyPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static RecurrencePolicyPagedQueryResponseQueryBuilderDsl Of()
        {
            return new RecurrencePolicyPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<RecurrencePolicyPagedQueryResponseQueryBuilderDsl>(p, RecurrencePolicyPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<RecurrencePolicyPagedQueryResponseQueryBuilderDsl>(p, RecurrencePolicyPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<RecurrencePolicyPagedQueryResponseQueryBuilderDsl>(p, RecurrencePolicyPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<RecurrencePolicyPagedQueryResponseQueryBuilderDsl>(p, RecurrencePolicyPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurrencePolicyPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyQueryBuilderDsl.Of())),
                RecurrencePolicyPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<RecurrencePolicyPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<RecurrencePolicyPagedQueryResponseQueryBuilderDsl>(p, RecurrencePolicyPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
