// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionCircularDependencyErrorQueryBuilderDsl
    {
        public ExtensionCircularDependencyErrorQueryBuilderDsl()
        {
        }

        public static ExtensionCircularDependencyErrorQueryBuilderDsl Of()
        {
            return new ExtensionCircularDependencyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionCircularDependencyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionCircularDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionCircularDependencyErrorQueryBuilderDsl>(p, ExtensionCircularDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionCircularDependencyErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionCircularDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionCircularDependencyErrorQueryBuilderDsl>(p, ExtensionCircularDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
