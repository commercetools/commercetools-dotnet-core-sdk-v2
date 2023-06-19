using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderImportCustomLineItemStateActionQueryBuilderDsl
    {
        public OrderImportCustomLineItemStateActionQueryBuilderDsl()
        {
        }

        public static OrderImportCustomLineItemStateActionQueryBuilderDsl Of()
        {
            return new OrderImportCustomLineItemStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderImportCustomLineItemStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderImportCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderImportCustomLineItemStateActionQueryBuilderDsl>(p, OrderImportCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderImportCustomLineItemStateActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<OrderImportCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<OrderImportCustomLineItemStateActionQueryBuilderDsl>(p, OrderImportCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderImportCustomLineItemStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportCustomLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                OrderImportCustomLineItemStateActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderImportCustomLineItemStateActionQueryBuilderDsl> State()
        {
            return new CollectionPredicateBuilder<OrderImportCustomLineItemStateActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
                    p => new CombinationQueryPredicate<OrderImportCustomLineItemStateActionQueryBuilderDsl>(p, OrderImportCustomLineItemStateActionQueryBuilderDsl.Of));
        }

    }
}
