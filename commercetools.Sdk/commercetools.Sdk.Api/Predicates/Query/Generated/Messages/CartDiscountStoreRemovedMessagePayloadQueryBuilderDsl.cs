using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl
    {
        public CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl>(p, CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                CartDiscountStoreRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
