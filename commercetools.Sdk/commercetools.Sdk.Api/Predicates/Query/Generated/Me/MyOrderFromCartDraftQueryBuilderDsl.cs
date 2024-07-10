using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyOrderFromCartDraftQueryBuilderDsl
    {
        public MyOrderFromCartDraftQueryBuilderDsl()
        {
        }

        public static MyOrderFromCartDraftQueryBuilderDsl Of()
        {
            return new MyOrderFromCartDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyOrderFromCartDraftQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<MyOrderFromCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<MyOrderFromCartDraftQueryBuilderDsl>(p, MyOrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyOrderFromCartDraftQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyOrderFromCartDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyOrderFromCartDraftQueryBuilderDsl>(p, MyOrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
