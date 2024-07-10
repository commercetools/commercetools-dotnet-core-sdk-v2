using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderRemoveDeliveryActionQueryBuilderDsl
    {
        public StagedOrderRemoveDeliveryActionQueryBuilderDsl()
        {
        }

        public static StagedOrderRemoveDeliveryActionQueryBuilderDsl Of()
        {
            return new StagedOrderRemoveDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderRemoveDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderRemoveDeliveryActionQueryBuilderDsl>(p, StagedOrderRemoveDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderRemoveDeliveryActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<StagedOrderRemoveDeliveryActionQueryBuilderDsl>(p, StagedOrderRemoveDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderRemoveDeliveryActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<StagedOrderRemoveDeliveryActionQueryBuilderDsl>(p, StagedOrderRemoveDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
