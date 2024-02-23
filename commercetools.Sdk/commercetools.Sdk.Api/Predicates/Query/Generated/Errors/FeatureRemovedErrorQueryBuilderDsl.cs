// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class FeatureRemovedErrorQueryBuilderDsl
    {
        public FeatureRemovedErrorQueryBuilderDsl()
        {
        }

        public static FeatureRemovedErrorQueryBuilderDsl Of()
        {
            return new FeatureRemovedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<FeatureRemovedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<FeatureRemovedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<FeatureRemovedErrorQueryBuilderDsl>(p, FeatureRemovedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FeatureRemovedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<FeatureRemovedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<FeatureRemovedErrorQueryBuilderDsl>(p, FeatureRemovedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
