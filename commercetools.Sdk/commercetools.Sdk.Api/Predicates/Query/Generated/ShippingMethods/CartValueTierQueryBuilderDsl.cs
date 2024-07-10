using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class CartValueTierQueryBuilderDsl
    {
        public CartValueTierQueryBuilderDsl()
        {
        }

        public static CartValueTierQueryBuilderDsl Of()
        {
            return new CartValueTierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartValueTierQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartValueTierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartValueTierQueryBuilderDsl>(p, CartValueTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartValueTierQueryBuilderDsl, long> MinimumCentAmount()
        {
            return new ComparisonPredicateBuilder<CartValueTierQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minimumCentAmount")),
            p => new CombinationQueryPredicate<CartValueTierQueryBuilderDsl>(p, CartValueTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartValueTierQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartValueTierQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartValueTierQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartValueTierQueryBuilderDsl, bool> IsMatching()
        {
            return new ComparisonPredicateBuilder<CartValueTierQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isMatching")),
            p => new CombinationQueryPredicate<CartValueTierQueryBuilderDsl>(p, CartValueTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
