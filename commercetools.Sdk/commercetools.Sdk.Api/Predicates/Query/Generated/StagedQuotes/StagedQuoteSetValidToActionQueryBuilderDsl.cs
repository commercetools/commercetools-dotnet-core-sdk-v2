using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteSetValidToActionQueryBuilderDsl
    {
        public StagedQuoteSetValidToActionQueryBuilderDsl()
        {
        }

        public static StagedQuoteSetValidToActionQueryBuilderDsl Of()
        {
            return new StagedQuoteSetValidToActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteSetValidToActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedQuoteSetValidToActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedQuoteSetValidToActionQueryBuilderDsl>(p, StagedQuoteSetValidToActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteSetValidToActionQueryBuilderDsl, DateTime> ValidTo()
        {
            return new ComparisonPredicateBuilder<StagedQuoteSetValidToActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validTo")),
            p => new CombinationQueryPredicate<StagedQuoteSetValidToActionQueryBuilderDsl>(p, StagedQuoteSetValidToActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
