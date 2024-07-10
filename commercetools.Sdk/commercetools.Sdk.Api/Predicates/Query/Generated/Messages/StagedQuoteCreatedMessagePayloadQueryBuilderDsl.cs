using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StagedQuoteCreatedMessagePayloadQueryBuilderDsl
    {
        public StagedQuoteCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StagedQuoteCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new StagedQuoteCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StagedQuoteCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StagedQuoteCreatedMessagePayloadQueryBuilderDsl>(p, StagedQuoteCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteCreatedMessagePayloadQueryBuilderDsl> StagedQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedQuote"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl.Of())),
                StagedQuoteCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
