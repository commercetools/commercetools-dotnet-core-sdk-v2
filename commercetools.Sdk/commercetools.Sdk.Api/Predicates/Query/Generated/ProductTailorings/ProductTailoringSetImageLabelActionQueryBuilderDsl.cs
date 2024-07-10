using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetImageLabelActionQueryBuilderDsl
    {
        public ProductTailoringSetImageLabelActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetImageLabelActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetImageLabelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetImageLabelActionQueryBuilderDsl>(p, ProductTailoringSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringSetImageLabelActionQueryBuilderDsl>(p, ProductTailoringSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringSetImageLabelActionQueryBuilderDsl>(p, ProductTailoringSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<ProductTailoringSetImageLabelActionQueryBuilderDsl>(p, ProductTailoringSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, string> Label()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("label")),
            p => new CombinationQueryPredicate<ProductTailoringSetImageLabelActionQueryBuilderDsl>(p, ProductTailoringSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetImageLabelActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetImageLabelActionQueryBuilderDsl>(p, ProductTailoringSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
