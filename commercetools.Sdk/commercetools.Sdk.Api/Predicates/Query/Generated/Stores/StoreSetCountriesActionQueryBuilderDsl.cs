using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetCountriesActionQueryBuilderDsl
    {
        public StoreSetCountriesActionQueryBuilderDsl()
        {
        }

        public static StoreSetCountriesActionQueryBuilderDsl Of()
        {
            return new StoreSetCountriesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetCountriesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetCountriesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetCountriesActionQueryBuilderDsl>(p, StoreSetCountriesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSetCountriesActionQueryBuilderDsl> Countries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSetCountriesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("countries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreSetCountriesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreSetCountriesActionQueryBuilderDsl> Countries()
        {
            return new CollectionPredicateBuilder<StoreSetCountriesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countries")),
                    p => new CombinationQueryPredicate<StoreSetCountriesActionQueryBuilderDsl>(p, StoreSetCountriesActionQueryBuilderDsl.Of));
        }

    }
}
