using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderChangeOrderStateActionQueryBuilderDsl
    {
        public OrderChangeOrderStateActionQueryBuilderDsl()
        {
        }

        public static OrderChangeOrderStateActionQueryBuilderDsl Of()
        {
            return new OrderChangeOrderStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderChangeOrderStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderChangeOrderStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderChangeOrderStateActionQueryBuilderDsl>(p, OrderChangeOrderStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderChangeOrderStateActionQueryBuilderDsl, string> OrderState()
        {
            return new ComparisonPredicateBuilder<OrderChangeOrderStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderState")),
            p => new CombinationQueryPredicate<OrderChangeOrderStateActionQueryBuilderDsl>(p, OrderChangeOrderStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
