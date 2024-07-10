using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class SuggestionQueryBuilderDsl
    {
        public SuggestionQueryBuilderDsl()
        {
        }

        public static SuggestionQueryBuilderDsl Of()
        {
            return new SuggestionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SuggestionQueryBuilderDsl, string> Text()
        {
            return new ComparisonPredicateBuilder<SuggestionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("text")),
            p => new CombinationQueryPredicate<SuggestionQueryBuilderDsl>(p, SuggestionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
