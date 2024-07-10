using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductLegacySetSkuActionQueryBuilderDsl
    {
        public ProductLegacySetSkuActionQueryBuilderDsl()
        {
        }

        public static ProductLegacySetSkuActionQueryBuilderDsl Of()
        {
            return new ProductLegacySetSkuActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductLegacySetSkuActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductLegacySetSkuActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductLegacySetSkuActionQueryBuilderDsl>(p, ProductLegacySetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductLegacySetSkuActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductLegacySetSkuActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductLegacySetSkuActionQueryBuilderDsl>(p, ProductLegacySetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductLegacySetSkuActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductLegacySetSkuActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductLegacySetSkuActionQueryBuilderDsl>(p, ProductLegacySetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
