using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl
    {
        public OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl>(p, OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
