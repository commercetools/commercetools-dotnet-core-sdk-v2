// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl
    {
        public StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl>(p, StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl>(p, StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl>(p, StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
