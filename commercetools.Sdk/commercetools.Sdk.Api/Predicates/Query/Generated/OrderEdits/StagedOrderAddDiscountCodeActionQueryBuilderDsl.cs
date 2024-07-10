// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderAddDiscountCodeActionQueryBuilderDsl
    {
        public StagedOrderAddDiscountCodeActionQueryBuilderDsl()
        {
        }

        public static StagedOrderAddDiscountCodeActionQueryBuilderDsl Of()
        {
            return new StagedOrderAddDiscountCodeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderAddDiscountCodeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderAddDiscountCodeActionQueryBuilderDsl>(p, StagedOrderAddDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddDiscountCodeActionQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<StagedOrderAddDiscountCodeActionQueryBuilderDsl>(p, StagedOrderAddDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
