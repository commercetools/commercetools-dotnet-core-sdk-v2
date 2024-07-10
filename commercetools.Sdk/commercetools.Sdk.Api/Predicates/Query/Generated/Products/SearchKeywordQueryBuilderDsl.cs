using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class SearchKeywordQueryBuilderDsl
    {
        public SearchKeywordQueryBuilderDsl()
        {
        }

        public static SearchKeywordQueryBuilderDsl Of()
        {
            return new SearchKeywordQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchKeywordQueryBuilderDsl, string> Text()
        {
            return new ComparisonPredicateBuilder<SearchKeywordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("text")),
            p => new CombinationQueryPredicate<SearchKeywordQueryBuilderDsl>(p, SearchKeywordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SearchKeywordQueryBuilderDsl> SuggestTokenizer(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.SuggestTokenizerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.SuggestTokenizerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchKeywordQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("suggestTokenizer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.SuggestTokenizerQueryBuilderDsl.Of())),
                SearchKeywordQueryBuilderDsl.Of);
        }


    }
}
