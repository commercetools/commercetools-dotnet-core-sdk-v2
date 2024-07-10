using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderAddReturnInfoActionQueryBuilderDsl
    {
        public OrderAddReturnInfoActionQueryBuilderDsl()
        {
        }

        public static OrderAddReturnInfoActionQueryBuilderDsl Of()
        {
            return new OrderAddReturnInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderAddReturnInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderAddReturnInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderAddReturnInfoActionQueryBuilderDsl>(p, OrderAddReturnInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderAddReturnInfoActionQueryBuilderDsl, string> ReturnTrackingId()
        {
            return new ComparisonPredicateBuilder<OrderAddReturnInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnTrackingId")),
            p => new CombinationQueryPredicate<OrderAddReturnInfoActionQueryBuilderDsl>(p, OrderAddReturnInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderAddReturnInfoActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddReturnInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl.Of())),
                OrderAddReturnInfoActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderAddReturnInfoActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<OrderAddReturnInfoActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<OrderAddReturnInfoActionQueryBuilderDsl>(p, OrderAddReturnInfoActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<OrderAddReturnInfoActionQueryBuilderDsl, DateTime> ReturnDate()
        {
            return new ComparisonPredicateBuilder<OrderAddReturnInfoActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnDate")),
            p => new CombinationQueryPredicate<OrderAddReturnInfoActionQueryBuilderDsl>(p, OrderAddReturnInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
