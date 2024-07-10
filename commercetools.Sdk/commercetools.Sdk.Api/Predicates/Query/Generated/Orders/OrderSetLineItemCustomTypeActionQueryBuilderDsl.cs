using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetLineItemCustomTypeActionQueryBuilderDsl
    {
        public OrderSetLineItemCustomTypeActionQueryBuilderDsl()
        {
        }

        public static OrderSetLineItemCustomTypeActionQueryBuilderDsl Of()
        {
            return new OrderSetLineItemCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetLineItemCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetLineItemCustomTypeActionQueryBuilderDsl>(p, OrderSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetLineItemCustomTypeActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderSetLineItemCustomTypeActionQueryBuilderDsl>(p, OrderSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetLineItemCustomTypeActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<OrderSetLineItemCustomTypeActionQueryBuilderDsl>(p, OrderSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetLineItemCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                OrderSetLineItemCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderSetLineItemCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                OrderSetLineItemCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
