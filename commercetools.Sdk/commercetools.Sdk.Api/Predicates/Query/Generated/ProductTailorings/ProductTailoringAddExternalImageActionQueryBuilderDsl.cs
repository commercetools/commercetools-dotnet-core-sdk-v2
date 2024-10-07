using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringAddExternalImageActionQueryBuilderDsl
    {
        public ProductTailoringAddExternalImageActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringAddExternalImageActionQueryBuilderDsl Of()
        {
            return new ProductTailoringAddExternalImageActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringAddExternalImageActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddExternalImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringAddExternalImageActionQueryBuilderDsl>(p, ProductTailoringAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringAddExternalImageActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddExternalImageActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringAddExternalImageActionQueryBuilderDsl>(p, ProductTailoringAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringAddExternalImageActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddExternalImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringAddExternalImageActionQueryBuilderDsl>(p, ProductTailoringAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringAddExternalImageActionQueryBuilderDsl> Image(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringAddExternalImageActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("image"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductTailoringAddExternalImageActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringAddExternalImageActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddExternalImageActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringAddExternalImageActionQueryBuilderDsl>(p, ProductTailoringAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
