using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetLineItemCustomFieldActionQueryBuilderDsl
    {
        public OrderSetLineItemCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetLineItemCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetLineItemCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderSetLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<OrderSetLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
