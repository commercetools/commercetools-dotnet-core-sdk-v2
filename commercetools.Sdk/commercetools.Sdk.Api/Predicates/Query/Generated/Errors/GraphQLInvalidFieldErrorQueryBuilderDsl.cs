// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidFieldErrorQueryBuilderDsl
    {
        public GraphQLInvalidFieldErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidFieldErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidFieldErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidFieldErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidFieldErrorQueryBuilderDsl>(p, GraphQLInvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLInvalidFieldErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<GraphQLInvalidFieldErrorQueryBuilderDsl>(p, GraphQLInvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLInvalidFieldErrorQueryBuilderDsl, string> InvalidValue()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("invalidValue")),
            p => new CombinationQueryPredicate<GraphQLInvalidFieldErrorQueryBuilderDsl>(p, GraphQLInvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLInvalidFieldErrorQueryBuilderDsl, string> AllowedValues()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("allowedValues")),
            p => new CombinationQueryPredicate<GraphQLInvalidFieldErrorQueryBuilderDsl>(p, GraphQLInvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
