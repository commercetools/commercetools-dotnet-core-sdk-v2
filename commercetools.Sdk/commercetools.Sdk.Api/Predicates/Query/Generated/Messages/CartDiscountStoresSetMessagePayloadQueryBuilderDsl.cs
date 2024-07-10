using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartDiscountStoresSetMessagePayloadQueryBuilderDsl
    {
        public CartDiscountStoresSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartDiscountStoresSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CartDiscountStoresSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountStoresSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountStoresSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountStoresSetMessagePayloadQueryBuilderDsl>(p, CartDiscountStoresSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountStoresSetMessagePayloadQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountStoresSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                CartDiscountStoresSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountStoresSetMessagePayloadQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CartDiscountStoresSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CartDiscountStoresSetMessagePayloadQueryBuilderDsl>(p, CartDiscountStoresSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
