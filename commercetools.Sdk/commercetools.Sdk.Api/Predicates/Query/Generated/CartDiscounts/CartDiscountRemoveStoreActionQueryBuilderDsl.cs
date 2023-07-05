using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountRemoveStoreActionQueryBuilderDsl
    {
        public CartDiscountRemoveStoreActionQueryBuilderDsl()
        {
        }

        public static CartDiscountRemoveStoreActionQueryBuilderDsl Of()
        {
            return new CartDiscountRemoveStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountRemoveStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountRemoveStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountRemoveStoreActionQueryBuilderDsl>(p, CartDiscountRemoveStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountRemoveStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountRemoveStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountRemoveStoreActionQueryBuilderDsl.Of);
        }


    }
}
