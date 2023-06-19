// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class CartsConfigurationQueryBuilderDsl
    {
        public CartsConfigurationQueryBuilderDsl()
        {
        }

        public static CartsConfigurationQueryBuilderDsl Of()
        {
            return new CartsConfigurationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartsConfigurationQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<CartsConfigurationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<CartsConfigurationQueryBuilderDsl>(p, CartsConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartsConfigurationQueryBuilderDsl, bool> CountryTaxRateFallbackEnabled()
        {
            return new ComparisonPredicateBuilder<CartsConfigurationQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countryTaxRateFallbackEnabled")),
            p => new CombinationQueryPredicate<CartsConfigurationQueryBuilderDsl>(p, CartsConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
