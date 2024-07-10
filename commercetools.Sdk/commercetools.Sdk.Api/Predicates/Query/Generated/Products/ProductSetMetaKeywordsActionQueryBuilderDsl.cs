using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetMetaKeywordsActionQueryBuilderDsl
    {
        public ProductSetMetaKeywordsActionQueryBuilderDsl()
        {
        }

        public static ProductSetMetaKeywordsActionQueryBuilderDsl Of()
        {
            return new ProductSetMetaKeywordsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetMetaKeywordsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetMetaKeywordsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetMetaKeywordsActionQueryBuilderDsl>(p, ProductSetMetaKeywordsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetMetaKeywordsActionQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetMetaKeywordsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductSetMetaKeywordsActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSetMetaKeywordsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetMetaKeywordsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetMetaKeywordsActionQueryBuilderDsl>(p, ProductSetMetaKeywordsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
