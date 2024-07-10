using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class CartScoreTypeQueryBuilderDsl
    {
        public CartScoreTypeQueryBuilderDsl()
        {
        }

        public static CartScoreTypeQueryBuilderDsl Of()
        {
            return new CartScoreTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartScoreTypeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartScoreTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartScoreTypeQueryBuilderDsl>(p, CartScoreTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
