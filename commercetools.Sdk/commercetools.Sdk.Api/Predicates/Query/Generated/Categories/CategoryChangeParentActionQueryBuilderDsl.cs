using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryChangeParentActionQueryBuilderDsl
    {
        public CategoryChangeParentActionQueryBuilderDsl()
        {
        }

        public static CategoryChangeParentActionQueryBuilderDsl Of()
        {
            return new CategoryChangeParentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryChangeParentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryChangeParentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryChangeParentActionQueryBuilderDsl>(p, CategoryChangeParentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryChangeParentActionQueryBuilderDsl> Parent(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryChangeParentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parent"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl.Of())),
                CategoryChangeParentActionQueryBuilderDsl.Of);
        }


    }
}
