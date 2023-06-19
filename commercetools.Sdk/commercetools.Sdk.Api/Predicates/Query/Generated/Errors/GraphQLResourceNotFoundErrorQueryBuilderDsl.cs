// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLResourceNotFoundErrorQueryBuilderDsl
    {
        public GraphQLResourceNotFoundErrorQueryBuilderDsl()
        {
        }

        public static GraphQLResourceNotFoundErrorQueryBuilderDsl Of()
        {
            return new GraphQLResourceNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLResourceNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLResourceNotFoundErrorQueryBuilderDsl>(p, GraphQLResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
