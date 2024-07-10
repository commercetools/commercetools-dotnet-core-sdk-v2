using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl
    {
        public StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl()
        {
        }

        public static StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl Of()
        {
            return new StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl>(p, StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl, string> StagedQuoteState()
        {
            return new ComparisonPredicateBuilder<StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedQuoteState")),
            p => new CombinationQueryPredicate<StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl>(p, StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
