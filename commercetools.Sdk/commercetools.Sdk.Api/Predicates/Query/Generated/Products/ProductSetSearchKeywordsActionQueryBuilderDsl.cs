using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetSearchKeywordsActionQueryBuilderDsl
    {
        public ProductSetSearchKeywordsActionQueryBuilderDsl()
        {
        }

        public static ProductSetSearchKeywordsActionQueryBuilderDsl Of()
        {
            return new ProductSetSearchKeywordsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetSearchKeywordsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetSearchKeywordsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetSearchKeywordsActionQueryBuilderDsl>(p, ProductSetSearchKeywordsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetSearchKeywordsActionQueryBuilderDsl> SearchKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetSearchKeywordsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("searchKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl.Of())),
                ProductSetSearchKeywordsActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSetSearchKeywordsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetSearchKeywordsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetSearchKeywordsActionQueryBuilderDsl>(p, ProductSetSearchKeywordsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
