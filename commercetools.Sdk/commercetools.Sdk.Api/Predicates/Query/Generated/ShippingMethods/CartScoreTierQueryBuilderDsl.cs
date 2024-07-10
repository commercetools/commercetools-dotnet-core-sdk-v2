using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class CartScoreTierQueryBuilderDsl
    {
        public CartScoreTierQueryBuilderDsl()
        {
        }

        public static CartScoreTierQueryBuilderDsl Of()
        {
            return new CartScoreTierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartScoreTierQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartScoreTierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartScoreTierQueryBuilderDsl>(p, CartScoreTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartScoreTierQueryBuilderDsl, long> Score()
        {
            return new ComparisonPredicateBuilder<CartScoreTierQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("score")),
            p => new CombinationQueryPredicate<CartScoreTierQueryBuilderDsl>(p, CartScoreTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartScoreTierQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartScoreTierQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartScoreTierQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartScoreTierQueryBuilderDsl> PriceFunction(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.PriceFunctionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.PriceFunctionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartScoreTierQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("priceFunction"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.PriceFunctionQueryBuilderDsl.Of())),
                CartScoreTierQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartScoreTierQueryBuilderDsl, bool> IsMatching()
        {
            return new ComparisonPredicateBuilder<CartScoreTierQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isMatching")),
            p => new CombinationQueryPredicate<CartScoreTierQueryBuilderDsl>(p, CartScoreTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
