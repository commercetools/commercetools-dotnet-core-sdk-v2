using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryChangeNameActionQueryBuilderDsl
    {
        public CategoryChangeNameActionQueryBuilderDsl()
        {
        }

        public static CategoryChangeNameActionQueryBuilderDsl Of()
        {
            return new CategoryChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryChangeNameActionQueryBuilderDsl>(p, CategoryChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryChangeNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryChangeNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryChangeNameActionQueryBuilderDsl.Of);
        }


    }
}
