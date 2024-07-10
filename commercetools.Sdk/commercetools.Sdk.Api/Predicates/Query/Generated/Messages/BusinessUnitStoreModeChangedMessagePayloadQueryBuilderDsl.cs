using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl, string> StoreMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeMode")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl> OldStores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldStores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl> OldStores()
        {
            return new CollectionPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStores")),
                    p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl, string> OldStoreMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStoreMode")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
