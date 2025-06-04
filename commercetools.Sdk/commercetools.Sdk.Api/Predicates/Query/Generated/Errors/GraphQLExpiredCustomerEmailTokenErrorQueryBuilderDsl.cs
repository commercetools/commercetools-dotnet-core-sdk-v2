// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExpiredCustomerEmailTokenErrorQueryBuilderDsl
    {
        public GraphQLExpiredCustomerEmailTokenErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExpiredCustomerEmailTokenErrorQueryBuilderDsl Of()
        {
            return new GraphQLExpiredCustomerEmailTokenErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExpiredCustomerEmailTokenErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExpiredCustomerEmailTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExpiredCustomerEmailTokenErrorQueryBuilderDsl>(p, GraphQLExpiredCustomerEmailTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
