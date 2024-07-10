using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetStoreModeActionQueryBuilderDsl
    {
        public BusinessUnitSetStoreModeActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetStoreModeActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetStoreModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetStoreModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetStoreModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetStoreModeActionQueryBuilderDsl>(p, BusinessUnitSetStoreModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSetStoreModeActionQueryBuilderDsl, string> StoreMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetStoreModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeMode")),
            p => new CombinationQueryPredicate<BusinessUnitSetStoreModeActionQueryBuilderDsl>(p, BusinessUnitSetStoreModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitSetStoreModeActionQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSetStoreModeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                BusinessUnitSetStoreModeActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitSetStoreModeActionQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<BusinessUnitSetStoreModeActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<BusinessUnitSetStoreModeActionQueryBuilderDsl>(p, BusinessUnitSetStoreModeActionQueryBuilderDsl.Of));
        }

    }
}
