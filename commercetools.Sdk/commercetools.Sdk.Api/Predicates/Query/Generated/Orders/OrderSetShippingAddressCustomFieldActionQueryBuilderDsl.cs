using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetShippingAddressCustomFieldActionQueryBuilderDsl
    {
        public OrderSetShippingAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetShippingAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetShippingAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
