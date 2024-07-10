using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderFromQuoteDraftQueryBuilderDsl
    {
        public OrderFromQuoteDraftQueryBuilderDsl()
        {
        }

        public static OrderFromQuoteDraftQueryBuilderDsl Of()
        {
            return new OrderFromQuoteDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl> Quote(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quote"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteResourceIdentifierQueryBuilderDsl.Of())),
                OrderFromQuoteDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl>(p, OrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, bool> QuoteStateToAccepted()
        {
            return new ComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteStateToAccepted")),
            p => new CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl>(p, OrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, string> OrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderNumber")),
            p => new CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl>(p, OrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl>(p, OrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl>(p, OrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, string> OrderState()
        {
            return new ComparisonPredicateBuilder<OrderFromQuoteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderState")),
            p => new CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl>(p, OrderFromQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderFromQuoteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                OrderFromQuoteDraftQueryBuilderDsl.Of);
        }


    }
}
