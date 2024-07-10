// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLOverCapacityErrorQueryBuilderDsl
    {
        public GraphQLOverCapacityErrorQueryBuilderDsl()
        {
        }

        public static GraphQLOverCapacityErrorQueryBuilderDsl Of()
        {
            return new GraphQLOverCapacityErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLOverCapacityErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLOverCapacityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLOverCapacityErrorQueryBuilderDsl>(p, GraphQLOverCapacityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
