using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryUpdateQueryBuilderDsl
    {
        public CategoryUpdateQueryBuilderDsl()
        {
        }

        public static CategoryUpdateQueryBuilderDsl Of()
        {
            return new CategoryUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CategoryUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CategoryUpdateQueryBuilderDsl>(p, CategoryUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryUpdateActionQueryBuilderDsl.Of())),
                CategoryUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CategoryUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<CategoryUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<CategoryUpdateQueryBuilderDsl>(p, CategoryUpdateQueryBuilderDsl.Of));
        }

    }
}
