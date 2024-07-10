using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryUpdateActionQueryBuilderDsl
    {
        public TaxCategoryUpdateActionQueryBuilderDsl()
        {
        }

        public static TaxCategoryUpdateActionQueryBuilderDsl Of()
        {
            return new TaxCategoryUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TaxCategoryUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl>(p, TaxCategoryUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl> AsAddTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryAddTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryAddTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryAddTaxRateActionQueryBuilderDsl.Of()),
                TaxCategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryChangeNameActionQueryBuilderDsl.Of()),
                TaxCategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl> AsRemoveTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryRemoveTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryRemoveTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryRemoveTaxRateActionQueryBuilderDsl.Of()),
                TaxCategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl> AsReplaceTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReplaceTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReplaceTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReplaceTaxRateActionQueryBuilderDsl.Of()),
                TaxCategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategorySetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategorySetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategorySetDescriptionActionQueryBuilderDsl.Of()),
                TaxCategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategorySetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategorySetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategorySetKeyActionQueryBuilderDsl.Of()),
                TaxCategoryUpdateActionQueryBuilderDsl.Of);
        }
    }
}
