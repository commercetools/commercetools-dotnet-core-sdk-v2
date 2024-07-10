using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetProductVariantKeyActionQueryBuilderDsl
    {
        public ProductSetProductVariantKeyActionQueryBuilderDsl()
        {
        }

        public static ProductSetProductVariantKeyActionQueryBuilderDsl Of()
        {
            return new ProductSetProductVariantKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetProductVariantKeyActionQueryBuilderDsl>(p, ProductSetProductVariantKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetProductVariantKeyActionQueryBuilderDsl>(p, ProductSetProductVariantKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetProductVariantKeyActionQueryBuilderDsl>(p, ProductSetProductVariantKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSetProductVariantKeyActionQueryBuilderDsl>(p, ProductSetProductVariantKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetProductVariantKeyActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetProductVariantKeyActionQueryBuilderDsl>(p, ProductSetProductVariantKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
