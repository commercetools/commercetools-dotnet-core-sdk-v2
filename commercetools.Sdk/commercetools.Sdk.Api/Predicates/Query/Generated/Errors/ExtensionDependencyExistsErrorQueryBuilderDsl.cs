// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionDependencyExistsErrorQueryBuilderDsl
    {
        public ExtensionDependencyExistsErrorQueryBuilderDsl()
        {
        }

        public static ExtensionDependencyExistsErrorQueryBuilderDsl Of()
        {
            return new ExtensionDependencyExistsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionDependencyExistsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionDependencyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionDependencyExistsErrorQueryBuilderDsl>(p, ExtensionDependencyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionDependencyExistsErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionDependencyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionDependencyExistsErrorQueryBuilderDsl>(p, ExtensionDependencyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
