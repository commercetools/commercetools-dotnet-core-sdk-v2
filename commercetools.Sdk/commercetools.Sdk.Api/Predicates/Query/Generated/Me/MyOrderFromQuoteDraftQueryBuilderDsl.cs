using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyOrderFromQuoteDraftQueryBuilderDsl
    {
        public MyOrderFromQuoteDraftQueryBuilderDsl()
        {
        }

        public static MyOrderFromQuoteDraftQueryBuilderDsl Of()
        {
            return new MyOrderFromQuoteDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyOrderFromQuoteDraftQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<MyOrderFromQuoteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<MyOrderFromQuoteDraftQueryBuilderDsl>(p, MyOrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyOrderFromQuoteDraftQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyOrderFromQuoteDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyOrderFromQuoteDraftQueryBuilderDsl>(p, MyOrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyOrderFromQuoteDraftQueryBuilderDsl, bool> QuoteStateToAccepted()
        {
            return new ComparisonPredicateBuilder<MyOrderFromQuoteDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteStateToAccepted")),
            p => new CombinationQueryPredicate<MyOrderFromQuoteDraftQueryBuilderDsl>(p, MyOrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
