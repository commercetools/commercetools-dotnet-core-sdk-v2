using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetMetaKeywordsActionQueryBuilderDsl
    {
        public CategorySetMetaKeywordsActionQueryBuilderDsl()
        {
        }

        public static CategorySetMetaKeywordsActionQueryBuilderDsl Of()
        {
            return new CategorySetMetaKeywordsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetMetaKeywordsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetMetaKeywordsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetMetaKeywordsActionQueryBuilderDsl>(p, CategorySetMetaKeywordsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategorySetMetaKeywordsActionQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategorySetMetaKeywordsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategorySetMetaKeywordsActionQueryBuilderDsl.Of);
        }


    }
}
