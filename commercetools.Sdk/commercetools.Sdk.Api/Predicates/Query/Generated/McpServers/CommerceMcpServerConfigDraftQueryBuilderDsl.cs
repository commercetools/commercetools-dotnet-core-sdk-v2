using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class CommerceMcpServerConfigDraftQueryBuilderDsl
    {
        public CommerceMcpServerConfigDraftQueryBuilderDsl()
        {
        }

        public static CommerceMcpServerConfigDraftQueryBuilderDsl Of()
        {
            return new CommerceMcpServerConfigDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl>(p, CommerceMcpServerConfigDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl, string> MajorVersion()
        {
            return new ComparisonPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("majorVersion")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl>(p, CommerceMcpServerConfigDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl, string> Tools()
        {
            return new ComparableCollectionPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tools")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl>(p, CommerceMcpServerConfigDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl> ToolCustomizations(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toolCustomizations"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl.Of())),
                CommerceMcpServerConfigDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl> ToolCustomizations()
        {
            return new CollectionPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("toolCustomizations")),
                    p => new CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl>(p, CommerceMcpServerConfigDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl> JsonOutputFiltering(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("jsonOutputFiltering"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl.Of())),
                CommerceMcpServerConfigDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl, string> ToolOutputFormatting()
        {
            return new ComparisonPredicateBuilder<CommerceMcpServerConfigDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("toolOutputFormatting")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigDraftQueryBuilderDsl>(p, CommerceMcpServerConfigDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
