using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl
    {
        public ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl()
        {
        }

        public static ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl Of()
        {
            return new ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>(p, ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>(p, ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl> ExistingVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("existingVariantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of);
        }


    }
}
