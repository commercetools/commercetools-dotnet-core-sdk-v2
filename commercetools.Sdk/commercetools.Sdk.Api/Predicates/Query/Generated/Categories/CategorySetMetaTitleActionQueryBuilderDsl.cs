using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetMetaTitleActionQueryBuilderDsl
    {
        public CategorySetMetaTitleActionQueryBuilderDsl()
        {
        }

        public static CategorySetMetaTitleActionQueryBuilderDsl Of()
        {
            return new CategorySetMetaTitleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetMetaTitleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetMetaTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetMetaTitleActionQueryBuilderDsl>(p, CategorySetMetaTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategorySetMetaTitleActionQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategorySetMetaTitleActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategorySetMetaTitleActionQueryBuilderDsl.Of);
        }


    }
}
