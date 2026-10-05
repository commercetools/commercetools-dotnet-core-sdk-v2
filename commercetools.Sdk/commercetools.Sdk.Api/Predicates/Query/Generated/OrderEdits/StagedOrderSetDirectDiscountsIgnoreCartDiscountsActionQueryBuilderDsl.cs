// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl
    {
        public StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl>(p, StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl, bool> DirectDiscountsIgnoreCartDiscounts()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("directDiscountsIgnoreCartDiscounts")),
            p => new CombinationQueryPredicate<StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl>(p, StagedOrderSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
