using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerSetToolCustomizationsActionQueryBuilderDsl
    {
        public McpServerSetToolCustomizationsActionQueryBuilderDsl()
        {
        }

        public static McpServerSetToolCustomizationsActionQueryBuilderDsl Of()
        {
            return new McpServerSetToolCustomizationsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerSetToolCustomizationsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerSetToolCustomizationsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerSetToolCustomizationsActionQueryBuilderDsl>(p, McpServerSetToolCustomizationsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerSetToolCustomizationsActionQueryBuilderDsl> ToolCustomizations(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerSetToolCustomizationsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toolCustomizations"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl.Of())),
                McpServerSetToolCustomizationsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<McpServerSetToolCustomizationsActionQueryBuilderDsl> ToolCustomizations()
        {
            return new CollectionPredicateBuilder<McpServerSetToolCustomizationsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("toolCustomizations")),
                    p => new CombinationQueryPredicate<McpServerSetToolCustomizationsActionQueryBuilderDsl>(p, McpServerSetToolCustomizationsActionQueryBuilderDsl.Of));
        }

    }
}
