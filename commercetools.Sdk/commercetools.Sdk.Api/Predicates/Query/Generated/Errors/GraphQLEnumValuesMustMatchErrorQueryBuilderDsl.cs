// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLEnumValuesMustMatchErrorQueryBuilderDsl
    {
        public GraphQLEnumValuesMustMatchErrorQueryBuilderDsl()
        {
        }

        public static GraphQLEnumValuesMustMatchErrorQueryBuilderDsl Of()
        {
            return new GraphQLEnumValuesMustMatchErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLEnumValuesMustMatchErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLEnumValuesMustMatchErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLEnumValuesMustMatchErrorQueryBuilderDsl>(p, GraphQLEnumValuesMustMatchErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
