// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLSemanticErrorErrorQueryBuilderDsl
    {
        public GraphQLSemanticErrorErrorQueryBuilderDsl()
        {
        }

        public static GraphQLSemanticErrorErrorQueryBuilderDsl Of()
        {
            return new GraphQLSemanticErrorErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLSemanticErrorErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLSemanticErrorErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLSemanticErrorErrorQueryBuilderDsl>(p, GraphQLSemanticErrorErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
