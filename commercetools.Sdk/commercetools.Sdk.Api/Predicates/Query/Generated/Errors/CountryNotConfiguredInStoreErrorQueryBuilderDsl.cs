// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class CountryNotConfiguredInStoreErrorQueryBuilderDsl
    {
        public CountryNotConfiguredInStoreErrorQueryBuilderDsl()
        {
        }

        public static CountryNotConfiguredInStoreErrorQueryBuilderDsl Of()
        {
            return new CountryNotConfiguredInStoreErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CountryNotConfiguredInStoreErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<CountryNotConfiguredInStoreErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<CountryNotConfiguredInStoreErrorQueryBuilderDsl>(p, CountryNotConfiguredInStoreErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountryNotConfiguredInStoreErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<CountryNotConfiguredInStoreErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<CountryNotConfiguredInStoreErrorQueryBuilderDsl>(p, CountryNotConfiguredInStoreErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CountryNotConfiguredInStoreErrorQueryBuilderDsl, string> StoreCountries()
        {
            return new ComparableCollectionPredicateBuilder<CountryNotConfiguredInStoreErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeCountries")),
            p => new CombinationQueryPredicate<CountryNotConfiguredInStoreErrorQueryBuilderDsl>(p, CountryNotConfiguredInStoreErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountryNotConfiguredInStoreErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<CountryNotConfiguredInStoreErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<CountryNotConfiguredInStoreErrorQueryBuilderDsl>(p, CountryNotConfiguredInStoreErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
