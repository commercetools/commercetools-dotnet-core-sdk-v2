using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteCreatedMessagePayloadQueryBuilderDsl
    {
        public QuoteCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteCreatedMessagePayloadQueryBuilderDsl>(p, QuoteCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteCreatedMessagePayloadQueryBuilderDsl> Quote(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quote"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl.Of())),
                QuoteCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
