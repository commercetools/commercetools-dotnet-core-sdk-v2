using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryChangeSlugActionQueryBuilderDsl
    {
        public CategoryChangeSlugActionQueryBuilderDsl()
        {
        }

        public static CategoryChangeSlugActionQueryBuilderDsl Of()
        {
            return new CategoryChangeSlugActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryChangeSlugActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryChangeSlugActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryChangeSlugActionQueryBuilderDsl>(p, CategoryChangeSlugActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryChangeSlugActionQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryChangeSlugActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryChangeSlugActionQueryBuilderDsl.Of);
        }


    }
}
