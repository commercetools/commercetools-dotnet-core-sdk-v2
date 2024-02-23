// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLReferenceExistsErrorQueryBuilderDsl
    {
        public GraphQLReferenceExistsErrorQueryBuilderDsl()
        {
        }

        public static GraphQLReferenceExistsErrorQueryBuilderDsl Of()
        {
            return new GraphQLReferenceExistsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLReferenceExistsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLReferenceExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLReferenceExistsErrorQueryBuilderDsl>(p, GraphQLReferenceExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLReferenceExistsErrorQueryBuilderDsl, string> ReferencedBy()
        {
            return new ComparisonPredicateBuilder<GraphQLReferenceExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("referencedBy")),
            p => new CombinationQueryPredicate<GraphQLReferenceExistsErrorQueryBuilderDsl>(p, GraphQLReferenceExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
