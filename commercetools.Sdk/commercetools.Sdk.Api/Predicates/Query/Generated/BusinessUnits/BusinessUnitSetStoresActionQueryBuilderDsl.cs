using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetStoresActionQueryBuilderDsl
    {
        public BusinessUnitSetStoresActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetStoresActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetStoresActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetStoresActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetStoresActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetStoresActionQueryBuilderDsl>(p, BusinessUnitSetStoresActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitSetStoresActionQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSetStoresActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                BusinessUnitSetStoresActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitSetStoresActionQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<BusinessUnitSetStoresActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<BusinessUnitSetStoresActionQueryBuilderDsl>(p, BusinessUnitSetStoresActionQueryBuilderDsl.Of));
        }

    }
}
