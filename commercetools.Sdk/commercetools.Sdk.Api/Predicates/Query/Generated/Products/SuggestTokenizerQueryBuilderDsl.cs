using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class SuggestTokenizerQueryBuilderDsl
    {
        public SuggestTokenizerQueryBuilderDsl()
        {
        }

        public static SuggestTokenizerQueryBuilderDsl Of()
        {
            return new SuggestTokenizerQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SuggestTokenizerQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<SuggestTokenizerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<SuggestTokenizerQueryBuilderDsl>(p, SuggestTokenizerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<SuggestTokenizerQueryBuilderDsl> AsCustom(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.CustomTokenizerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.CustomTokenizerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SuggestTokenizerQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.CustomTokenizerQueryBuilderDsl.Of()),
                SuggestTokenizerQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SuggestTokenizerQueryBuilderDsl> AsWhitespace(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.WhitespaceTokenizerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.WhitespaceTokenizerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SuggestTokenizerQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.WhitespaceTokenizerQueryBuilderDsl.Of()),
                SuggestTokenizerQueryBuilderDsl.Of);
        }
    }
}
