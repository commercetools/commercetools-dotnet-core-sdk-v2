using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetSkuActionQueryBuilderDsl
    {
        public ProductSetSkuActionQueryBuilderDsl()
        {
        }

        public static ProductSetSkuActionQueryBuilderDsl Of()
        {
            return new ProductSetSkuActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetSkuActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetSkuActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetSkuActionQueryBuilderDsl>(p, ProductSetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetSkuActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetSkuActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetSkuActionQueryBuilderDsl>(p, ProductSetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetSkuActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetSkuActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetSkuActionQueryBuilderDsl>(p, ProductSetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetSkuActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetSkuActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetSkuActionQueryBuilderDsl>(p, ProductSetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
