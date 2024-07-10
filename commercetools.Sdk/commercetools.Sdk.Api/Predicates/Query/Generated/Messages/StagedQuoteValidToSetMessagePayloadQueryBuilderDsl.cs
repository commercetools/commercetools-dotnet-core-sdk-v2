using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StagedQuoteValidToSetMessagePayloadQueryBuilderDsl
    {
        public StagedQuoteValidToSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StagedQuoteValidToSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StagedQuoteValidToSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessagePayloadQueryBuilderDsl>(p, StagedQuoteValidToSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessagePayloadQueryBuilderDsl, DateTime> ValidTo()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validTo")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessagePayloadQueryBuilderDsl>(p, StagedQuoteValidToSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
