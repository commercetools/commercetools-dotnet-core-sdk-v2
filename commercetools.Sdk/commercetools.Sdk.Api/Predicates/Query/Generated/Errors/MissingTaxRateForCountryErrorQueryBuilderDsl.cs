// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MissingTaxRateForCountryErrorQueryBuilderDsl
    {
        public MissingTaxRateForCountryErrorQueryBuilderDsl()
        {
        }

        public static MissingTaxRateForCountryErrorQueryBuilderDsl Of()
        {
            return new MissingTaxRateForCountryErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MissingTaxRateForCountryErrorQueryBuilderDsl>(p, MissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MissingTaxRateForCountryErrorQueryBuilderDsl>(p, MissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string> TaxCategoryId()
        {
            return new ComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCategoryId")),
            p => new CombinationQueryPredicate<MissingTaxRateForCountryErrorQueryBuilderDsl>(p, MissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<MissingTaxRateForCountryErrorQueryBuilderDsl>(p, MissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<MissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<MissingTaxRateForCountryErrorQueryBuilderDsl>(p, MissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
