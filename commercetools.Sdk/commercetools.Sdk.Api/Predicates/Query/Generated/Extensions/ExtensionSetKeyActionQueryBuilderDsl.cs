// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionSetKeyActionQueryBuilderDsl
    {
        public ExtensionSetKeyActionQueryBuilderDsl()
        {
        }

        public static ExtensionSetKeyActionQueryBuilderDsl Of()
        {
            return new ExtensionSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionSetKeyActionQueryBuilderDsl>(p, ExtensionSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ExtensionSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ExtensionSetKeyActionQueryBuilderDsl>(p, ExtensionSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
