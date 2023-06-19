using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetMetaDescriptionActionQueryBuilderDsl
    {
        public CategorySetMetaDescriptionActionQueryBuilderDsl()
        {
        }

        public static CategorySetMetaDescriptionActionQueryBuilderDsl Of()
        {
            return new CategorySetMetaDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetMetaDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetMetaDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetMetaDescriptionActionQueryBuilderDsl>(p, CategorySetMetaDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategorySetMetaDescriptionActionQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategorySetMetaDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategorySetMetaDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
