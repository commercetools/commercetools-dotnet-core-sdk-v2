using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerSetJsonOutputFilteringActionQueryBuilderDsl
    {
        public McpServerSetJsonOutputFilteringActionQueryBuilderDsl()
        {
        }

        public static McpServerSetJsonOutputFilteringActionQueryBuilderDsl Of()
        {
            return new McpServerSetJsonOutputFilteringActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerSetJsonOutputFilteringActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerSetJsonOutputFilteringActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerSetJsonOutputFilteringActionQueryBuilderDsl>(p, McpServerSetJsonOutputFilteringActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerSetJsonOutputFilteringActionQueryBuilderDsl> JsonOutputFiltering(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerSetJsonOutputFilteringActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("jsonOutputFiltering"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl.Of())),
                McpServerSetJsonOutputFilteringActionQueryBuilderDsl.Of);
        }


    }
}
