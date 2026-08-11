using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerRemoveToolCustomizationActionQueryBuilderDsl
    {
        public McpServerRemoveToolCustomizationActionQueryBuilderDsl()
        {
        }

        public static McpServerRemoveToolCustomizationActionQueryBuilderDsl Of()
        {
            return new McpServerRemoveToolCustomizationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerRemoveToolCustomizationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerRemoveToolCustomizationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerRemoveToolCustomizationActionQueryBuilderDsl>(p, McpServerRemoveToolCustomizationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerRemoveToolCustomizationActionQueryBuilderDsl> ToolCustomization(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.RemoveToolCustomizationTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.RemoveToolCustomizationTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerRemoveToolCustomizationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toolCustomization"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.RemoveToolCustomizationTargetQueryBuilderDsl.Of())),
                McpServerRemoveToolCustomizationActionQueryBuilderDsl.Of);
        }


    }
}
