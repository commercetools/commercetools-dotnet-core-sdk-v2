using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ShoppingListStoreSetMessagePayloadQueryBuilderDsl
    {
        public ShoppingListStoreSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ShoppingListStoreSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ShoppingListStoreSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListStoreSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShoppingListStoreSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShoppingListStoreSetMessagePayloadQueryBuilderDsl>(p, ShoppingListStoreSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListStoreSetMessagePayloadQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListStoreSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                ShoppingListStoreSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
