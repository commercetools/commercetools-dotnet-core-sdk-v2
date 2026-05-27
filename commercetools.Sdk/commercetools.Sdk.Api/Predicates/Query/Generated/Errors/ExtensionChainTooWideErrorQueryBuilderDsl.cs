// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionChainTooWideErrorQueryBuilderDsl
    {
        public ExtensionChainTooWideErrorQueryBuilderDsl()
        {
        }

        public static ExtensionChainTooWideErrorQueryBuilderDsl Of()
        {
            return new ExtensionChainTooWideErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionChainTooWideErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionChainTooWideErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionChainTooWideErrorQueryBuilderDsl>(p, ExtensionChainTooWideErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionChainTooWideErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionChainTooWideErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionChainTooWideErrorQueryBuilderDsl>(p, ExtensionChainTooWideErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
