// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLContentTooLargeErrorQueryBuilderDsl
    {
        public GraphQLContentTooLargeErrorQueryBuilderDsl()
        {
        }

        public static GraphQLContentTooLargeErrorQueryBuilderDsl Of()
        {
            return new GraphQLContentTooLargeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLContentTooLargeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLContentTooLargeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLContentTooLargeErrorQueryBuilderDsl>(p, GraphQLContentTooLargeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
