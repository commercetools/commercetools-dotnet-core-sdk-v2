using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderImportLineItemStateActionQueryBuilderDsl
    {
        public OrderImportLineItemStateActionQueryBuilderDsl()
        {
        }

        public static OrderImportLineItemStateActionQueryBuilderDsl Of()
        {
            return new OrderImportLineItemStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderImportLineItemStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderImportLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderImportLineItemStateActionQueryBuilderDsl>(p, OrderImportLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderImportLineItemStateActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderImportLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderImportLineItemStateActionQueryBuilderDsl>(p, OrderImportLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderImportLineItemStateActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderImportLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<OrderImportLineItemStateActionQueryBuilderDsl>(p, OrderImportLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderImportLineItemStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                OrderImportLineItemStateActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderImportLineItemStateActionQueryBuilderDsl> State()
        {
            return new CollectionPredicateBuilder<OrderImportLineItemStateActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
                    p => new CombinationQueryPredicate<OrderImportLineItemStateActionQueryBuilderDsl>(p, OrderImportLineItemStateActionQueryBuilderDsl.Of));
        }

    }
}
