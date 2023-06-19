// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLGeneralErrorQueryBuilderDsl
    {
        public GraphQLGeneralErrorQueryBuilderDsl()
        {
        }

        public static GraphQLGeneralErrorQueryBuilderDsl Of()
        {
            return new GraphQLGeneralErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLGeneralErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLGeneralErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLGeneralErrorQueryBuilderDsl>(p, GraphQLGeneralErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
