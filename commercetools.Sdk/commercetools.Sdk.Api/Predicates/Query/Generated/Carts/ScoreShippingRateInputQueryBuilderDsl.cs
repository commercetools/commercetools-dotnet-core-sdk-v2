// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ScoreShippingRateInputQueryBuilderDsl
    {
        public ScoreShippingRateInputQueryBuilderDsl()
        {
        }

        public static ScoreShippingRateInputQueryBuilderDsl Of()
        {
            return new ScoreShippingRateInputQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ScoreShippingRateInputQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ScoreShippingRateInputQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ScoreShippingRateInputQueryBuilderDsl>(p, ScoreShippingRateInputQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ScoreShippingRateInputQueryBuilderDsl, long> Score()
        {
            return new ComparisonPredicateBuilder<ScoreShippingRateInputQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("score")),
            p => new CombinationQueryPredicate<ScoreShippingRateInputQueryBuilderDsl>(p, ScoreShippingRateInputQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
