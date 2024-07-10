using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl
    {
        public GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl Of()
        {
            return new GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl>(p, GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, string> TaxCategoryId()
        {
            return new ComparisonPredicateBuilder<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCategoryId")),
            p => new CombinationQueryPredicate<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl>(p, GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl>(p, GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl>(p, GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
