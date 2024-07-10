using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditSetCommentActionQueryBuilderDsl
    {
        public OrderEditSetCommentActionQueryBuilderDsl()
        {
        }

        public static OrderEditSetCommentActionQueryBuilderDsl Of()
        {
            return new OrderEditSetCommentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditSetCommentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderEditSetCommentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderEditSetCommentActionQueryBuilderDsl>(p, OrderEditSetCommentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditSetCommentActionQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<OrderEditSetCommentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<OrderEditSetCommentActionQueryBuilderDsl>(p, OrderEditSetCommentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
