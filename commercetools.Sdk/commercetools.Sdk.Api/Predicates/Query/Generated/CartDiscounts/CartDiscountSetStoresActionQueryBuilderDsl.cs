using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountSetStoresActionQueryBuilderDsl
    {
        public CartDiscountSetStoresActionQueryBuilderDsl()
        {
        }

        public static CartDiscountSetStoresActionQueryBuilderDsl Of()
        {
            return new CartDiscountSetStoresActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountSetStoresActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetStoresActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountSetStoresActionQueryBuilderDsl>(p, CartDiscountSetStoresActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountSetStoresActionQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountSetStoresActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountSetStoresActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountSetStoresActionQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CartDiscountSetStoresActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CartDiscountSetStoresActionQueryBuilderDsl>(p, CartDiscountSetStoresActionQueryBuilderDsl.Of));
        }

    }
}
