// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerTypeToolQueryBuilderDsl
    {
        public McpServerTypeToolQueryBuilderDsl()
        {
        }

        public static McpServerTypeToolQueryBuilderDsl Of()
        {
            return new McpServerTypeToolQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerTypeToolQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<McpServerTypeToolQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<McpServerTypeToolQueryBuilderDsl>(p, McpServerTypeToolQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerTypeToolQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<McpServerTypeToolQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<McpServerTypeToolQueryBuilderDsl>(p, McpServerTypeToolQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerTypeToolQueryBuilderDsl, string> OperationType()
        {
            return new ComparisonPredicateBuilder<McpServerTypeToolQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("operationType")),
            p => new CombinationQueryPredicate<McpServerTypeToolQueryBuilderDsl>(p, McpServerTypeToolQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<McpServerTypeToolQueryBuilderDsl, string> Groups()
        {
            return new ComparableCollectionPredicateBuilder<McpServerTypeToolQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("groups")),
            p => new CombinationQueryPredicate<McpServerTypeToolQueryBuilderDsl>(p, McpServerTypeToolQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
