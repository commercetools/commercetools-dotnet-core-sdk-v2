using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyQuoteRequestDraftQueryBuilderDsl
    {
        public MyQuoteRequestDraftQueryBuilderDsl()
        {
        }

        public static MyQuoteRequestDraftQueryBuilderDsl Of()
        {
            return new MyQuoteRequestDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyQuoteRequestDraftQueryBuilderDsl, string> CartId()
        {
            return new ComparisonPredicateBuilder<MyQuoteRequestDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartId")),
            p => new CombinationQueryPredicate<MyQuoteRequestDraftQueryBuilderDsl>(p, MyQuoteRequestDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyQuoteRequestDraftQueryBuilderDsl, long> CartVersion()
        {
            return new ComparisonPredicateBuilder<MyQuoteRequestDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartVersion")),
            p => new CombinationQueryPredicate<MyQuoteRequestDraftQueryBuilderDsl>(p, MyQuoteRequestDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyQuoteRequestDraftQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<MyQuoteRequestDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<MyQuoteRequestDraftQueryBuilderDsl>(p, MyQuoteRequestDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
