using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class WhitespaceTokenizerQueryBuilderDsl
    {
        public WhitespaceTokenizerQueryBuilderDsl()
        {
        }

        public static WhitespaceTokenizerQueryBuilderDsl Of()
        {
            return new WhitespaceTokenizerQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<WhitespaceTokenizerQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<WhitespaceTokenizerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<WhitespaceTokenizerQueryBuilderDsl>(p, WhitespaceTokenizerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
