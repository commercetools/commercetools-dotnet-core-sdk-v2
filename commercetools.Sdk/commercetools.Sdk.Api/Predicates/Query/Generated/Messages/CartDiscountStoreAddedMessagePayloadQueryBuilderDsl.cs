using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartDiscountStoreAddedMessagePayloadQueryBuilderDsl
    {
        public CartDiscountStoreAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartDiscountStoreAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new CartDiscountStoreAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountStoreAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountStoreAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountStoreAddedMessagePayloadQueryBuilderDsl>(p, CartDiscountStoreAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountStoreAddedMessagePayloadQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountStoreAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                CartDiscountStoreAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
