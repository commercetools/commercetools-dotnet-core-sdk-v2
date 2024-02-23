// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl
    {
        public GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl()
        {
        }

        public static GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl Of()
        {
            return new GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl>(p, GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl, string> ConflictingEnumKey()
        {
            return new ComparisonPredicateBuilder<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingEnumKey")),
            p => new CombinationQueryPredicate<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl>(p, GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl, string> ConflictingAttributeName()
        {
            return new ComparisonPredicateBuilder<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingAttributeName")),
            p => new CombinationQueryPredicate<GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl>(p, GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
