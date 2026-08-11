using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerSetNameActionQueryBuilderDsl
    {
        public McpServerSetNameActionQueryBuilderDsl()
        {
        }

        public static McpServerSetNameActionQueryBuilderDsl Of()
        {
            return new McpServerSetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerSetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerSetNameActionQueryBuilderDsl>(p, McpServerSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerSetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerSetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                McpServerSetNameActionQueryBuilderDsl.Of);
        }


    }
}
