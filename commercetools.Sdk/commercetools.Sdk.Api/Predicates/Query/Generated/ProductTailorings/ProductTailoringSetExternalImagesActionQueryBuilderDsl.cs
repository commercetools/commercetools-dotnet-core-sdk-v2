using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetExternalImagesActionQueryBuilderDsl
    {
        public ProductTailoringSetExternalImagesActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetExternalImagesActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetExternalImagesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetExternalImagesActionQueryBuilderDsl>(p, ProductTailoringSetExternalImagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringSetExternalImagesActionQueryBuilderDsl>(p, ProductTailoringSetExternalImagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringSetExternalImagesActionQueryBuilderDsl>(p, ProductTailoringSetExternalImagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringSetExternalImagesActionQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringSetExternalImagesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductTailoringSetExternalImagesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<ProductTailoringSetExternalImagesActionQueryBuilderDsl>(p, ProductTailoringSetExternalImagesActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetExternalImagesActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetExternalImagesActionQueryBuilderDsl>(p, ProductTailoringSetExternalImagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
