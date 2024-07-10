using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetDeliveryItemsActionQueryBuilderDsl
    {
        public StagedOrderSetDeliveryItemsActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetDeliveryItemsActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetDeliveryItemsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetDeliveryItemsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryItemsActionQueryBuilderDsl>(p, StagedOrderSetDeliveryItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryItemsActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryItemsActionQueryBuilderDsl>(p, StagedOrderSetDeliveryItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryItemsActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryItemsActionQueryBuilderDsl>(p, StagedOrderSetDeliveryItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetDeliveryItemsActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetDeliveryItemsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                StagedOrderSetDeliveryItemsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderSetDeliveryItemsActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<StagedOrderSetDeliveryItemsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<StagedOrderSetDeliveryItemsActionQueryBuilderDsl>(p, StagedOrderSetDeliveryItemsActionQueryBuilderDsl.Of));
        }

    }
}
