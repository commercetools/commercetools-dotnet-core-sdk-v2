using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteRequestCreatedMessagePayloadQueryBuilderDsl
    {
        public QuoteRequestCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteRequestCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteRequestCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteRequestCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteRequestCreatedMessagePayloadQueryBuilderDsl>(p, QuoteRequestCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestCreatedMessagePayloadQueryBuilderDsl> QuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quoteRequest"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl.Of())),
                QuoteRequestCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
