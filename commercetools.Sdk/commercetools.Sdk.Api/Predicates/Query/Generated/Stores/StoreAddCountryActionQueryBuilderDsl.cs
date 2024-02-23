using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreAddCountryActionQueryBuilderDsl
    {
        public StoreAddCountryActionQueryBuilderDsl()
        {
        }

        public static StoreAddCountryActionQueryBuilderDsl Of()
        {
            return new StoreAddCountryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreAddCountryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreAddCountryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreAddCountryActionQueryBuilderDsl>(p, StoreAddCountryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreAddCountryActionQueryBuilderDsl> Country(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreAddCountryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("country"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreAddCountryActionQueryBuilderDsl.Of);
        }


    }
}
