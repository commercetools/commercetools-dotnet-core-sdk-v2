using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class CartClassificationTierQueryBuilderDsl
    {
        public CartClassificationTierQueryBuilderDsl()
        {
        }

        public static CartClassificationTierQueryBuilderDsl Of()
        {
            return new CartClassificationTierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartClassificationTierQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartClassificationTierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartClassificationTierQueryBuilderDsl>(p, CartClassificationTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartClassificationTierQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CartClassificationTierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CartClassificationTierQueryBuilderDsl>(p, CartClassificationTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartClassificationTierQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartClassificationTierQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartClassificationTierQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartClassificationTierQueryBuilderDsl, bool> IsMatching()
        {
            return new ComparisonPredicateBuilder<CartClassificationTierQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isMatching")),
            p => new CombinationQueryPredicate<CartClassificationTierQueryBuilderDsl>(p, CartClassificationTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
