// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicateFieldErrorQueryBuilderDsl
    {
        public GraphQLDuplicateFieldErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicateFieldErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicateFieldErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateFieldErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicateFieldErrorQueryBuilderDsl>(p, GraphQLDuplicateFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDuplicateFieldErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<GraphQLDuplicateFieldErrorQueryBuilderDsl>(p, GraphQLDuplicateFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDuplicateFieldErrorQueryBuilderDsl, string> DuplicateValue()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("duplicateValue")),
            p => new CombinationQueryPredicate<GraphQLDuplicateFieldErrorQueryBuilderDsl>(p, GraphQLDuplicateFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
