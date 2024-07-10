using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryRemoveTaxRateActionQueryBuilderDsl
    {
        public TaxCategoryRemoveTaxRateActionQueryBuilderDsl()
        {
        }

        public static TaxCategoryRemoveTaxRateActionQueryBuilderDsl Of()
        {
            return new TaxCategoryRemoveTaxRateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryRemoveTaxRateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TaxCategoryRemoveTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TaxCategoryRemoveTaxRateActionQueryBuilderDsl>(p, TaxCategoryRemoveTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryRemoveTaxRateActionQueryBuilderDsl, string> TaxRateId()
        {
            return new ComparisonPredicateBuilder<TaxCategoryRemoveTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRateId")),
            p => new CombinationQueryPredicate<TaxCategoryRemoveTaxRateActionQueryBuilderDsl>(p, TaxCategoryRemoveTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryRemoveTaxRateActionQueryBuilderDsl, string> TaxRateKey()
        {
            return new ComparisonPredicateBuilder<TaxCategoryRemoveTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRateKey")),
            p => new CombinationQueryPredicate<TaxCategoryRemoveTaxRateActionQueryBuilderDsl>(p, TaxCategoryRemoveTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
