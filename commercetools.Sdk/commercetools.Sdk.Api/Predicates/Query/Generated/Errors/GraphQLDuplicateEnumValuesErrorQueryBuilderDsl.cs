// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicateEnumValuesErrorQueryBuilderDsl
    {
        public GraphQLDuplicateEnumValuesErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicateEnumValuesErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicateEnumValuesErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateEnumValuesErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateEnumValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicateEnumValuesErrorQueryBuilderDsl>(p, GraphQLDuplicateEnumValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<GraphQLDuplicateEnumValuesErrorQueryBuilderDsl, string> Duplicates()
        {
            return new ComparableCollectionPredicateBuilder<GraphQLDuplicateEnumValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("duplicates")),
            p => new CombinationQueryPredicate<GraphQLDuplicateEnumValuesErrorQueryBuilderDsl>(p, GraphQLDuplicateEnumValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
