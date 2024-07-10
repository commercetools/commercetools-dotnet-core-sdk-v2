using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryReplaceTaxRateActionQueryBuilderDsl
    {
        public TaxCategoryReplaceTaxRateActionQueryBuilderDsl()
        {
        }

        public static TaxCategoryReplaceTaxRateActionQueryBuilderDsl Of()
        {
            return new TaxCategoryReplaceTaxRateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryReplaceTaxRateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TaxCategoryReplaceTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TaxCategoryReplaceTaxRateActionQueryBuilderDsl>(p, TaxCategoryReplaceTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryReplaceTaxRateActionQueryBuilderDsl, string> TaxRateId()
        {
            return new ComparisonPredicateBuilder<TaxCategoryReplaceTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRateId")),
            p => new CombinationQueryPredicate<TaxCategoryReplaceTaxRateActionQueryBuilderDsl>(p, TaxCategoryReplaceTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryReplaceTaxRateActionQueryBuilderDsl, string> TaxRateKey()
        {
            return new ComparisonPredicateBuilder<TaxCategoryReplaceTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRateKey")),
            p => new CombinationQueryPredicate<TaxCategoryReplaceTaxRateActionQueryBuilderDsl>(p, TaxCategoryReplaceTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxCategoryReplaceTaxRateActionQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryReplaceTaxRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl.Of())),
                TaxCategoryReplaceTaxRateActionQueryBuilderDsl.Of);
        }


    }
}
