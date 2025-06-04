// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExpiredCustomerPasswordTokenErrorQueryBuilderDsl
    {
        public GraphQLExpiredCustomerPasswordTokenErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExpiredCustomerPasswordTokenErrorQueryBuilderDsl Of()
        {
            return new GraphQLExpiredCustomerPasswordTokenErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExpiredCustomerPasswordTokenErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExpiredCustomerPasswordTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExpiredCustomerPasswordTokenErrorQueryBuilderDsl>(p, GraphQLExpiredCustomerPasswordTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
