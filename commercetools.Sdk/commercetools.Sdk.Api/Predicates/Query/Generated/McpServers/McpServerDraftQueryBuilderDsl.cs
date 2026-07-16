using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerDraftQueryBuilderDsl
    {
        public McpServerDraftQueryBuilderDsl()
        {
        }

        public static McpServerDraftQueryBuilderDsl Of()
        {
            return new McpServerDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<McpServerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<McpServerDraftQueryBuilderDsl>(p, McpServerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                McpServerDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<McpServerDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                McpServerDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<McpServerDraftQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<McpServerDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<McpServerDraftQueryBuilderDsl>(p, McpServerDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerDraftQueryBuilderDsl> McpServer(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerConfigDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerConfigDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("mcpServer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerConfigDraftQueryBuilderDsl.Of())),
                McpServerDraftQueryBuilderDsl.Of);
        }


    }
}
