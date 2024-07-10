using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangeShipmentStateActionQueryBuilderDsl
    {
        public StagedOrderChangeShipmentStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangeShipmentStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangeShipmentStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangeShipmentStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangeShipmentStateActionQueryBuilderDsl>(p, StagedOrderChangeShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeShipmentStateActionQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<StagedOrderChangeShipmentStateActionQueryBuilderDsl>(p, StagedOrderChangeShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
