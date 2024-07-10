using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl
    {
        public OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
