using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerConfigDraftQueryBuilderDsl
    {
        public McpServerConfigDraftQueryBuilderDsl()
        {
        }

        public static McpServerConfigDraftQueryBuilderDsl Of()
        {
            return new McpServerConfigDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerConfigDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<McpServerConfigDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<McpServerConfigDraftQueryBuilderDsl>(p, McpServerConfigDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<McpServerConfigDraftQueryBuilderDsl> AsCommerceMcp(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.CommerceMcpServerConfigDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.CommerceMcpServerConfigDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerConfigDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.CommerceMcpServerConfigDraftQueryBuilderDsl.Of()),
                McpServerConfigDraftQueryBuilderDsl.Of);
        }
    }
}
