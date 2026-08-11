using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class CommerceMcpServerConfigQueryBuilderDsl
    {
        public CommerceMcpServerConfigQueryBuilderDsl()
        {
        }

        public static CommerceMcpServerConfigQueryBuilderDsl Of()
        {
            return new CommerceMcpServerConfigQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl>(p, CommerceMcpServerConfigQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string> MajorVersion()
        {
            return new ComparisonPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("majorVersion")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl>(p, CommerceMcpServerConfigQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string> Url()
        {
            return new ComparisonPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("url")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl>(p, CommerceMcpServerConfigQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string> Tools()
        {
            return new ComparableCollectionPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tools")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl>(p, CommerceMcpServerConfigQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl> ToolCustomizations(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toolCustomizations"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.ToolCustomizationQueryBuilderDsl.Of())),
                CommerceMcpServerConfigQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl> ToolCustomizations()
        {
            return new CollectionPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("toolCustomizations")),
                    p => new CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl>(p, CommerceMcpServerConfigQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl> JsonOutputFiltering(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("jsonOutputFiltering"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringQueryBuilderDsl.Of())),
                CommerceMcpServerConfigQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string> ToolOutputFormatting()
        {
            return new ComparisonPredicateBuilder<CommerceMcpServerConfigQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("toolOutputFormatting")),
            p => new CombinationQueryPredicate<CommerceMcpServerConfigQueryBuilderDsl>(p, CommerceMcpServerConfigQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
