// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StoreCountries
{

    public partial class StoreCountryQueryBuilderDsl
    {
        public StoreCountryQueryBuilderDsl()
        {
        }

        public static StoreCountryQueryBuilderDsl Of()
        {
            return new StoreCountryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCountryQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<StoreCountryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<StoreCountryQueryBuilderDsl>(p, StoreCountryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
