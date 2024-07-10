using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductAddToCategoryActionQueryBuilderDsl
    {
        public ProductAddToCategoryActionQueryBuilderDsl()
        {
        }

        public static ProductAddToCategoryActionQueryBuilderDsl Of()
        {
            return new ProductAddToCategoryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductAddToCategoryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductAddToCategoryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductAddToCategoryActionQueryBuilderDsl>(p, ProductAddToCategoryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddToCategoryActionQueryBuilderDsl> Category(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddToCategoryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("category"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl.Of())),
                ProductAddToCategoryActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductAddToCategoryActionQueryBuilderDsl, string> OrderHint()
        {
            return new ComparisonPredicateBuilder<ProductAddToCategoryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderHint")),
            p => new CombinationQueryPredicate<ProductAddToCategoryActionQueryBuilderDsl>(p, ProductAddToCategoryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddToCategoryActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductAddToCategoryActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductAddToCategoryActionQueryBuilderDsl>(p, ProductAddToCategoryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
