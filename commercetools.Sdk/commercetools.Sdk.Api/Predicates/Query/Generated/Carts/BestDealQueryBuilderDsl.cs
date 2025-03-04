// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class BestDealQueryBuilderDsl
    {
        public BestDealQueryBuilderDsl()
        {
        }

        public static BestDealQueryBuilderDsl Of()
        {
            return new BestDealQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BestDealQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BestDealQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BestDealQueryBuilderDsl>(p, BestDealQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BestDealQueryBuilderDsl, string> ChosenDiscountType()
        {
            return new ComparisonPredicateBuilder<BestDealQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("chosenDiscountType")),
            p => new CombinationQueryPredicate<BestDealQueryBuilderDsl>(p, BestDealQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
