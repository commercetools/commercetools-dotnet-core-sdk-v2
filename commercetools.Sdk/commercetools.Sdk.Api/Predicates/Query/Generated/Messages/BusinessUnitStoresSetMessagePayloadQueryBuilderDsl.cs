using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitStoresSetMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitStoresSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitStoresSetMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitStoresSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitStoresSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoresSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitStoresSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitStoresSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitStoresSetMessagePayloadQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoresSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitStoresSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitStoresSetMessagePayloadQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<BusinessUnitStoresSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<BusinessUnitStoresSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitStoresSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
