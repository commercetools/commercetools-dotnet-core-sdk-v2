// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerJsonOutputFilteringMatcherQueryBuilderDsl
    {
        public McpServerJsonOutputFilteringMatcherQueryBuilderDsl()
        {
        }

        public static McpServerJsonOutputFilteringMatcherQueryBuilderDsl Of()
        {
            return new McpServerJsonOutputFilteringMatcherQueryBuilderDsl();
        }

        public IComparableCollectionPredicateBuilder<McpServerJsonOutputFilteringMatcherQueryBuilderDsl, string> FieldPaths()
        {
            return new ComparableCollectionPredicateBuilder<McpServerJsonOutputFilteringMatcherQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldPaths")),
            p => new CombinationQueryPredicate<McpServerJsonOutputFilteringMatcherQueryBuilderDsl>(p, McpServerJsonOutputFilteringMatcherQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<McpServerJsonOutputFilteringMatcherQueryBuilderDsl, string> FieldNames()
        {
            return new ComparableCollectionPredicateBuilder<McpServerJsonOutputFilteringMatcherQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldNames")),
            p => new CombinationQueryPredicate<McpServerJsonOutputFilteringMatcherQueryBuilderDsl>(p, McpServerJsonOutputFilteringMatcherQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<McpServerJsonOutputFilteringMatcherQueryBuilderDsl, string> FieldNameContains()
        {
            return new ComparableCollectionPredicateBuilder<McpServerJsonOutputFilteringMatcherQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldNameContains")),
            p => new CombinationQueryPredicate<McpServerJsonOutputFilteringMatcherQueryBuilderDsl>(p, McpServerJsonOutputFilteringMatcherQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
