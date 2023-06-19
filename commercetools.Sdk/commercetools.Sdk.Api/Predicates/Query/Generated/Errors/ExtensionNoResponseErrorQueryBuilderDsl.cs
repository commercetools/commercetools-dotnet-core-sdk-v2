// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionNoResponseErrorQueryBuilderDsl
    {
        public ExtensionNoResponseErrorQueryBuilderDsl()
        {
        }

        public static ExtensionNoResponseErrorQueryBuilderDsl Of()
        {
            return new ExtensionNoResponseErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionNoResponseErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionNoResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionNoResponseErrorQueryBuilderDsl>(p, ExtensionNoResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionNoResponseErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionNoResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionNoResponseErrorQueryBuilderDsl>(p, ExtensionNoResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionNoResponseErrorQueryBuilderDsl, string> ExtensionId()
        {
            return new ComparisonPredicateBuilder<ExtensionNoResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionId")),
            p => new CombinationQueryPredicate<ExtensionNoResponseErrorQueryBuilderDsl>(p, ExtensionNoResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionNoResponseErrorQueryBuilderDsl, string> ExtensionKey()
        {
            return new ComparisonPredicateBuilder<ExtensionNoResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionKey")),
            p => new CombinationQueryPredicate<ExtensionNoResponseErrorQueryBuilderDsl>(p, ExtensionNoResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
