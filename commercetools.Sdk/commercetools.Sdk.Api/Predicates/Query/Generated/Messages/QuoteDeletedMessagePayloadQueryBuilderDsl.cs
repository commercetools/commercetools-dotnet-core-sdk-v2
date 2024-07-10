using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteDeletedMessagePayloadQueryBuilderDsl
    {
        public QuoteDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteDeletedMessagePayloadQueryBuilderDsl>(p, QuoteDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
