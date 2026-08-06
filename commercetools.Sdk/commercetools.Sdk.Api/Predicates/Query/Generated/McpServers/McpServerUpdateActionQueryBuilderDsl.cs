using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerUpdateActionQueryBuilderDsl
    {
        public McpServerUpdateActionQueryBuilderDsl()
        {
        }

        public static McpServerUpdateActionQueryBuilderDsl Of()
        {
            return new McpServerUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(p, McpServerUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsAddTool(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerAddToolActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerAddToolActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerAddToolActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsAddToolCustomization(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerAddToolCustomizationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerAddToolCustomizationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerAddToolCustomizationActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsRemoveTool(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerRemoveToolActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerRemoveToolActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerRemoveToolActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsRemoveToolCustomization(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerRemoveToolCustomizationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerRemoveToolCustomizationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerRemoveToolCustomizationActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsSetAuthenticationMode(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetAuthenticationModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetAuthenticationModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetAuthenticationModeActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetDescriptionActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsSetJsonOutputFiltering(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetJsonOutputFilteringActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetJsonOutputFilteringActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetJsonOutputFilteringActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetNameActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsSetState(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetStateActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsSetToolCustomizations(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolCustomizationsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolCustomizationsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolCustomizationsActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsSetToolOutputFormatting(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolOutputFormattingActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolOutputFormattingActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolOutputFormattingActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl> AsSetTools(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerSetToolsActionQueryBuilderDsl.Of()),
                McpServerUpdateActionQueryBuilderDsl.Of);
        }
    }
}
