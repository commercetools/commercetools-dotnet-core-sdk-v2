using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductAddedToCategoryMessagePayloadQueryBuilderDsl
    {
        public ProductAddedToCategoryMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductAddedToCategoryMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductAddedToCategoryMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductAddedToCategoryMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessagePayloadQueryBuilderDsl>(p, ProductAddedToCategoryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddedToCategoryMessagePayloadQueryBuilderDsl> Category(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddedToCategoryMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("category"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                ProductAddedToCategoryMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductAddedToCategoryMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessagePayloadQueryBuilderDsl>(p, ProductAddedToCategoryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
