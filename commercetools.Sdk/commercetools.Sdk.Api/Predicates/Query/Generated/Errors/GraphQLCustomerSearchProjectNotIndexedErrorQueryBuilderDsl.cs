// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLCustomerSearchProjectNotIndexedErrorQueryBuilderDsl
    {
        public GraphQLCustomerSearchProjectNotIndexedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLCustomerSearchProjectNotIndexedErrorQueryBuilderDsl Of()
        {
            return new GraphQLCustomerSearchProjectNotIndexedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLCustomerSearchProjectNotIndexedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLCustomerSearchProjectNotIndexedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLCustomerSearchProjectNotIndexedErrorQueryBuilderDsl>(p, GraphQLCustomerSearchProjectNotIndexedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
