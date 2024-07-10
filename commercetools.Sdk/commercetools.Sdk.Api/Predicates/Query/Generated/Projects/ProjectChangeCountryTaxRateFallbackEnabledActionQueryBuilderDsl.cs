using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl
    {
        public ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl Of()
        {
            return new ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl>(p, ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl, bool> CountryTaxRateFallbackEnabled()
        {
            return new ComparisonPredicateBuilder<ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countryTaxRateFallbackEnabled")),
            p => new CombinationQueryPredicate<ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl>(p, ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
