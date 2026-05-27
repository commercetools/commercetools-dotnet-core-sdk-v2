// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionChainTooDeepErrorQueryBuilderDsl
    {
        public ExtensionChainTooDeepErrorQueryBuilderDsl()
        {
        }

        public static ExtensionChainTooDeepErrorQueryBuilderDsl Of()
        {
            return new ExtensionChainTooDeepErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionChainTooDeepErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionChainTooDeepErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionChainTooDeepErrorQueryBuilderDsl>(p, ExtensionChainTooDeepErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionChainTooDeepErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionChainTooDeepErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionChainTooDeepErrorQueryBuilderDsl>(p, ExtensionChainTooDeepErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
