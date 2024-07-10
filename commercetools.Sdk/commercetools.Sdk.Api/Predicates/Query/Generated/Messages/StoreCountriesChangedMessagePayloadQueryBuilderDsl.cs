using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreCountriesChangedMessagePayloadQueryBuilderDsl
    {
        public StoreCountriesChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreCountriesChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreCountriesChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCountriesChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreCountriesChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreCountriesChangedMessagePayloadQueryBuilderDsl>(p, StoreCountriesChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCountriesChangedMessagePayloadQueryBuilderDsl> AddedCountries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCountriesChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addedCountries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreCountriesChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCountriesChangedMessagePayloadQueryBuilderDsl> AddedCountries()
        {
            return new CollectionPredicateBuilder<StoreCountriesChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedCountries")),
                    p => new CombinationQueryPredicate<StoreCountriesChangedMessagePayloadQueryBuilderDsl>(p, StoreCountriesChangedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCountriesChangedMessagePayloadQueryBuilderDsl> RemovedCountries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCountriesChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedCountries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreCountriesChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCountriesChangedMessagePayloadQueryBuilderDsl> RemovedCountries()
        {
            return new CollectionPredicateBuilder<StoreCountriesChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedCountries")),
                    p => new CombinationQueryPredicate<StoreCountriesChangedMessagePayloadQueryBuilderDsl>(p, StoreCountriesChangedMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
