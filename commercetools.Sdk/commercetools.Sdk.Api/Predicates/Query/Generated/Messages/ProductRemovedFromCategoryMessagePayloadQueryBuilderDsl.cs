using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl
    {
        public ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl>(p, ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl> Category(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("category"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl>(p, ProductRemovedFromCategoryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
