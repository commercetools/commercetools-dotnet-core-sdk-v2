using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitAddStoreActionQueryBuilderDsl
    {
        public BusinessUnitAddStoreActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddStoreActionQueryBuilderDsl Of()
        {
            return new BusinessUnitAddStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitAddStoreActionQueryBuilderDsl>(p, BusinessUnitAddStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                BusinessUnitAddStoreActionQueryBuilderDsl.Of);
        }


    }
}
