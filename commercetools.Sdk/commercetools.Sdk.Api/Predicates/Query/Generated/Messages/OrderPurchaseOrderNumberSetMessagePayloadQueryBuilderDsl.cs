using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl
    {
        public OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string> OldPurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPurchaseOrderNumber")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
