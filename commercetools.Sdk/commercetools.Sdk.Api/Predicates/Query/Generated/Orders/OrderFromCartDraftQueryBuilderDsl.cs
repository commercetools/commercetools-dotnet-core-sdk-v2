using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderFromCartDraftQueryBuilderDsl
    {
        public OrderFromCartDraftQueryBuilderDsl()
        {
        }

        public static OrderFromCartDraftQueryBuilderDsl Of()
        {
            return new OrderFromCartDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(p, OrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl> Cart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl.Of())),
                OrderFromCartDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(p, OrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string> OrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderNumber")),
            p => new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(p, OrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(p, OrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(p, OrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(p, OrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string> OrderState()
        {
            return new ComparisonPredicateBuilder<OrderFromCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderState")),
            p => new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(p, OrderFromCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                OrderFromCartDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderFromCartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                OrderFromCartDraftQueryBuilderDsl.Of);
        }


    }
}
