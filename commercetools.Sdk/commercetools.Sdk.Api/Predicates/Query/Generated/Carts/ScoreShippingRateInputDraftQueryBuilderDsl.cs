// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ScoreShippingRateInputDraftQueryBuilderDsl
    {
        public ScoreShippingRateInputDraftQueryBuilderDsl()
        {
        }

        public static ScoreShippingRateInputDraftQueryBuilderDsl Of()
        {
            return new ScoreShippingRateInputDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ScoreShippingRateInputDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ScoreShippingRateInputDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ScoreShippingRateInputDraftQueryBuilderDsl>(p, ScoreShippingRateInputDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ScoreShippingRateInputDraftQueryBuilderDsl, long> Score()
        {
            return new ComparisonPredicateBuilder<ScoreShippingRateInputDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("score")),
            p => new CombinationQueryPredicate<ScoreShippingRateInputDraftQueryBuilderDsl>(p, ScoreShippingRateInputDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
