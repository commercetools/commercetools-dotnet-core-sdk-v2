using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteUpdateQueryBuilderDsl
    {
        public QuoteUpdateQueryBuilderDsl()
        {
        }

        public static QuoteUpdateQueryBuilderDsl Of()
        {
            return new QuoteUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<QuoteUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<QuoteUpdateQueryBuilderDsl>(p, QuoteUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteUpdateActionQueryBuilderDsl.Of())),
                QuoteUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QuoteUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<QuoteUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<QuoteUpdateQueryBuilderDsl>(p, QuoteUpdateQueryBuilderDsl.Of));
        }

    }
}
