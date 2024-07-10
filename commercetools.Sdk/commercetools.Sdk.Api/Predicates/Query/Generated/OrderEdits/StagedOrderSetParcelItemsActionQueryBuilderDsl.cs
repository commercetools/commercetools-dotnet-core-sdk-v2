using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetParcelItemsActionQueryBuilderDsl
    {
        public StagedOrderSetParcelItemsActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetParcelItemsActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetParcelItemsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetParcelItemsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelItemsActionQueryBuilderDsl>(p, StagedOrderSetParcelItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelItemsActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelItemsActionQueryBuilderDsl>(p, StagedOrderSetParcelItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelItemsActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelItemsActionQueryBuilderDsl>(p, StagedOrderSetParcelItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetParcelItemsActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetParcelItemsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                StagedOrderSetParcelItemsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderSetParcelItemsActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<StagedOrderSetParcelItemsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<StagedOrderSetParcelItemsActionQueryBuilderDsl>(p, StagedOrderSetParcelItemsActionQueryBuilderDsl.Of));
        }

    }
}
