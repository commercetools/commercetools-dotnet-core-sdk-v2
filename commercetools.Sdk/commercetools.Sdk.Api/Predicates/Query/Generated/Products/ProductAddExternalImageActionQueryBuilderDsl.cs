using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductAddExternalImageActionQueryBuilderDsl
    {
        public ProductAddExternalImageActionQueryBuilderDsl()
        {
        }

        public static ProductAddExternalImageActionQueryBuilderDsl Of()
        {
            return new ProductAddExternalImageActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductAddExternalImageActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductAddExternalImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductAddExternalImageActionQueryBuilderDsl>(p, ProductAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddExternalImageActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductAddExternalImageActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductAddExternalImageActionQueryBuilderDsl>(p, ProductAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddExternalImageActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductAddExternalImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductAddExternalImageActionQueryBuilderDsl>(p, ProductAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddExternalImageActionQueryBuilderDsl> Image(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddExternalImageActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("image"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductAddExternalImageActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductAddExternalImageActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductAddExternalImageActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductAddExternalImageActionQueryBuilderDsl>(p, ProductAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
