using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountAddStoreActionQueryBuilderDsl
    {
        public CartDiscountAddStoreActionQueryBuilderDsl()
        {
        }

        public static CartDiscountAddStoreActionQueryBuilderDsl Of()
        {
            return new CartDiscountAddStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountAddStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountAddStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountAddStoreActionQueryBuilderDsl>(p, CartDiscountAddStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountAddStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountAddStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountAddStoreActionQueryBuilderDsl.Of);
        }


    }
}
