using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryAddTaxRateActionQueryBuilderDsl
    {
        public TaxCategoryAddTaxRateActionQueryBuilderDsl()
        {
        }

        public static TaxCategoryAddTaxRateActionQueryBuilderDsl Of()
        {
            return new TaxCategoryAddTaxRateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryAddTaxRateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TaxCategoryAddTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TaxCategoryAddTaxRateActionQueryBuilderDsl>(p, TaxCategoryAddTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxCategoryAddTaxRateActionQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryAddTaxRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl.Of())),
                TaxCategoryAddTaxRateActionQueryBuilderDsl.Of);
        }


    }
}
