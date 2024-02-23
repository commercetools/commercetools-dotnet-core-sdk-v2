using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestUpdateQueryBuilderDsl
    {
        public QuoteRequestUpdateQueryBuilderDsl()
        {
        }

        public static QuoteRequestUpdateQueryBuilderDsl Of()
        {
            return new QuoteRequestUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<QuoteRequestUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<QuoteRequestUpdateQueryBuilderDsl>(p, QuoteRequestUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestUpdateActionQueryBuilderDsl.Of())),
                QuoteRequestUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QuoteRequestUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<QuoteRequestUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<QuoteRequestUpdateQueryBuilderDsl>(p, QuoteRequestUpdateQueryBuilderDsl.Of));
        }

    }
}
