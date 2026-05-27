// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionSetExpansionPathsActionQueryBuilderDsl
    {
        public ExtensionSetExpansionPathsActionQueryBuilderDsl()
        {
        }

        public static ExtensionSetExpansionPathsActionQueryBuilderDsl Of()
        {
            return new ExtensionSetExpansionPathsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionSetExpansionPathsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionSetExpansionPathsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionSetExpansionPathsActionQueryBuilderDsl>(p, ExtensionSetExpansionPathsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ExtensionSetExpansionPathsActionQueryBuilderDsl, string> ExpansionPaths()
        {
            return new ComparableCollectionPredicateBuilder<ExtensionSetExpansionPathsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expansionPaths")),
            p => new CombinationQueryPredicate<ExtensionSetExpansionPathsActionQueryBuilderDsl>(p, ExtensionSetExpansionPathsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
