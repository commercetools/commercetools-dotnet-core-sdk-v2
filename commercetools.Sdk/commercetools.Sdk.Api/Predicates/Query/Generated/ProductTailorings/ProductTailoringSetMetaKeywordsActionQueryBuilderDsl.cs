using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetMetaKeywordsActionQueryBuilderDsl
    {
        public ProductTailoringSetMetaKeywordsActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetMetaKeywordsActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetMetaKeywordsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetMetaKeywordsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetMetaKeywordsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetMetaKeywordsActionQueryBuilderDsl>(p, ProductTailoringSetMetaKeywordsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringSetMetaKeywordsActionQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringSetMetaKeywordsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringSetMetaKeywordsActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringSetMetaKeywordsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetMetaKeywordsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetMetaKeywordsActionQueryBuilderDsl>(p, ProductTailoringSetMetaKeywordsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
