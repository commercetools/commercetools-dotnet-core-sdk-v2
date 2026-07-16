using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerConfigQueryBuilderDsl
    {
        public McpServerConfigQueryBuilderDsl()
        {
        }

        public static McpServerConfigQueryBuilderDsl Of()
        {
            return new McpServerConfigQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerConfigQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<McpServerConfigQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<McpServerConfigQueryBuilderDsl>(p, McpServerConfigQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<McpServerConfigQueryBuilderDsl> AsCommerceMcp(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.CommerceMcpServerConfigQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.CommerceMcpServerConfigQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerConfigQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.CommerceMcpServerConfigQueryBuilderDsl.Of()),
                McpServerConfigQueryBuilderDsl.Of);
        }
    }
}
