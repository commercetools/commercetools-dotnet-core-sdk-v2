using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductRemoveFromCategoryActionQueryBuilderDsl
    {
        public ProductRemoveFromCategoryActionQueryBuilderDsl()
        {
        }

        public static ProductRemoveFromCategoryActionQueryBuilderDsl Of()
        {
            return new ProductRemoveFromCategoryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRemoveFromCategoryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductRemoveFromCategoryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductRemoveFromCategoryActionQueryBuilderDsl>(p, ProductRemoveFromCategoryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRemoveFromCategoryActionQueryBuilderDsl> Category(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRemoveFromCategoryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("category"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl.Of())),
                ProductRemoveFromCategoryActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductRemoveFromCategoryActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductRemoveFromCategoryActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductRemoveFromCategoryActionQueryBuilderDsl>(p, ProductRemoveFromCategoryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
