using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerAddToolCustomizationActionQueryBuilderDsl
    {
        public McpServerAddToolCustomizationActionQueryBuilderDsl()
        {
        }

        public static McpServerAddToolCustomizationActionQueryBuilderDsl Of()
        {
            return new McpServerAddToolCustomizationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerAddToolCustomizationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerAddToolCustomizationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerAddToolCustomizationActionQueryBuilderDsl>(p, McpServerAddToolCustomizationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerAddToolCustomizationActionQueryBuilderDsl> ToolCustomization(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerAddToolCustomizationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toolCustomization"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl.Of())),
                McpServerAddToolCustomizationActionQueryBuilderDsl.Of);
        }


    }
}
