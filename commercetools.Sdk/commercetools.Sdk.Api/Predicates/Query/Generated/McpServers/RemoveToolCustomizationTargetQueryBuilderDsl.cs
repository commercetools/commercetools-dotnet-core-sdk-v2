// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class RemoveToolCustomizationTargetQueryBuilderDsl
    {
        public RemoveToolCustomizationTargetQueryBuilderDsl()
        {
        }

        public static RemoveToolCustomizationTargetQueryBuilderDsl Of()
        {
            return new RemoveToolCustomizationTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RemoveToolCustomizationTargetQueryBuilderDsl, string> Tool()
        {
            return new ComparisonPredicateBuilder<RemoveToolCustomizationTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tool")),
            p => new CombinationQueryPredicate<RemoveToolCustomizationTargetQueryBuilderDsl>(p, RemoveToolCustomizationTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
