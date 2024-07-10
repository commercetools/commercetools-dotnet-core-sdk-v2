// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLRequiredFieldErrorQueryBuilderDsl
    {
        public GraphQLRequiredFieldErrorQueryBuilderDsl()
        {
        }

        public static GraphQLRequiredFieldErrorQueryBuilderDsl Of()
        {
            return new GraphQLRequiredFieldErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLRequiredFieldErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLRequiredFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLRequiredFieldErrorQueryBuilderDsl>(p, GraphQLRequiredFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLRequiredFieldErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<GraphQLRequiredFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<GraphQLRequiredFieldErrorQueryBuilderDsl>(p, GraphQLRequiredFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
