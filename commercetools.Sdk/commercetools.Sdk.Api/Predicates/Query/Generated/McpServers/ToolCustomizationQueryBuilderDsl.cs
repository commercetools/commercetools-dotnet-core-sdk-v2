using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class ToolCustomizationQueryBuilderDsl
    {
        public ToolCustomizationQueryBuilderDsl()
        {
        }

        public static ToolCustomizationQueryBuilderDsl Of()
        {
            return new ToolCustomizationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ToolCustomizationQueryBuilderDsl, string> Tool()
        {
            return new ComparisonPredicateBuilder<ToolCustomizationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tool")),
            p => new CombinationQueryPredicate<ToolCustomizationQueryBuilderDsl>(p, ToolCustomizationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ToolCustomizationQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ToolCustomizationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ToolCustomizationQueryBuilderDsl>(p, ToolCustomizationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ToolCustomizationQueryBuilderDsl> Parameters(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.ParameterOverrideQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.ParameterOverrideQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ToolCustomizationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parameters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.ParameterOverrideQueryBuilderDsl.Of())),
                ToolCustomizationQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ToolCustomizationQueryBuilderDsl> Parameters()
        {
            return new CollectionPredicateBuilder<ToolCustomizationQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parameters")),
                    p => new CombinationQueryPredicate<ToolCustomizationQueryBuilderDsl>(p, ToolCustomizationQueryBuilderDsl.Of));
        }

    }
}
