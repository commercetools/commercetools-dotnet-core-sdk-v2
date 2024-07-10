// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl
    {
        public GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl()
        {
        }

        public static GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl Of()
        {
            return new GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl>(p, GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl, string> ConflictingEnumKey()
        {
            return new ComparisonPredicateBuilder<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingEnumKey")),
            p => new CombinationQueryPredicate<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl>(p, GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl, string> ConflictingAttributeName()
        {
            return new ComparisonPredicateBuilder<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingAttributeName")),
            p => new CombinationQueryPredicate<GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl>(p, GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
