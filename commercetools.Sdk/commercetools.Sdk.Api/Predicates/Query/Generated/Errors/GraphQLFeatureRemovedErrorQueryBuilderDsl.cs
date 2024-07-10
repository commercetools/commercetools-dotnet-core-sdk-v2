// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLFeatureRemovedErrorQueryBuilderDsl
    {
        public GraphQLFeatureRemovedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLFeatureRemovedErrorQueryBuilderDsl Of()
        {
            return new GraphQLFeatureRemovedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLFeatureRemovedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLFeatureRemovedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLFeatureRemovedErrorQueryBuilderDsl>(p, GraphQLFeatureRemovedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
