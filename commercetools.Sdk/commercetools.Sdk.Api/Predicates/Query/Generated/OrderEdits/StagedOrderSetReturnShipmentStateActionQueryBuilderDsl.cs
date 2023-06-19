// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetReturnShipmentStateActionQueryBuilderDsl
    {
        public StagedOrderSetReturnShipmentStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetReturnShipmentStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetReturnShipmentStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl>(p, StagedOrderSetReturnShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl>(p, StagedOrderSetReturnShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnShipmentStateActionQueryBuilderDsl>(p, StagedOrderSetReturnShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
