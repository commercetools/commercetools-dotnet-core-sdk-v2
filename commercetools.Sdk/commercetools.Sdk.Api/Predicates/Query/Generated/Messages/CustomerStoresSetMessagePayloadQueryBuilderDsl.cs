using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerStoresSetMessagePayloadQueryBuilderDsl
    {
        public CustomerStoresSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerStoresSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerStoresSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerStoresSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerStoresSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerStoresSetMessagePayloadQueryBuilderDsl>(p, CustomerStoresSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerStoresSetMessagePayloadQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerStoresSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                CustomerStoresSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerStoresSetMessagePayloadQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CustomerStoresSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CustomerStoresSetMessagePayloadQueryBuilderDsl>(p, CustomerStoresSetMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CustomerStoresSetMessagePayloadQueryBuilderDsl> OldStores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerStoresSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldStores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                CustomerStoresSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerStoresSetMessagePayloadQueryBuilderDsl> OldStores()
        {
            return new CollectionPredicateBuilder<CustomerStoresSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStores")),
                    p => new CombinationQueryPredicate<CustomerStoresSetMessagePayloadQueryBuilderDsl>(p, CustomerStoresSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
