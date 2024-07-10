using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CategoryCreatedMessagePayloadQueryBuilderDsl
    {
        public CategoryCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CategoryCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new CategoryCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CategoryCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CategoryCreatedMessagePayloadQueryBuilderDsl>(p, CategoryCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryCreatedMessagePayloadQueryBuilderDsl> Category(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("category"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl.Of())),
                CategoryCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
