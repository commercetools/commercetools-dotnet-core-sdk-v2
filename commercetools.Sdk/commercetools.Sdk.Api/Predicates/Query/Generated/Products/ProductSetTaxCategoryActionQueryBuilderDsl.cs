using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetTaxCategoryActionQueryBuilderDsl
    {
        public ProductSetTaxCategoryActionQueryBuilderDsl()
        {
        }

        public static ProductSetTaxCategoryActionQueryBuilderDsl Of()
        {
            return new ProductSetTaxCategoryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetTaxCategoryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetTaxCategoryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetTaxCategoryActionQueryBuilderDsl>(p, ProductSetTaxCategoryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetTaxCategoryActionQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetTaxCategoryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                ProductSetTaxCategoryActionQueryBuilderDsl.Of);
        }


    }
}
