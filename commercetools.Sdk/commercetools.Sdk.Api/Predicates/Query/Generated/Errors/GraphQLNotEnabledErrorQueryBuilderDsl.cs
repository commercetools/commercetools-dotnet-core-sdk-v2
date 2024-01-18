// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLNotEnabledErrorQueryBuilderDsl
    {
        public GraphQLNotEnabledErrorQueryBuilderDsl()
        {
        }

        public static GraphQLNotEnabledErrorQueryBuilderDsl Of()
        {
            return new GraphQLNotEnabledErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLNotEnabledErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLNotEnabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLNotEnabledErrorQueryBuilderDsl>(p, GraphQLNotEnabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
