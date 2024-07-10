using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreRemoveCountryActionQueryBuilderDsl
    {
        public StoreRemoveCountryActionQueryBuilderDsl()
        {
        }

        public static StoreRemoveCountryActionQueryBuilderDsl Of()
        {
            return new StoreRemoveCountryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreRemoveCountryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreRemoveCountryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreRemoveCountryActionQueryBuilderDsl>(p, StoreRemoveCountryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreRemoveCountryActionQueryBuilderDsl> Country(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreRemoveCountryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("country"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreRemoveCountryActionQueryBuilderDsl.Of);
        }


    }
}
