// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ErrorByExtensionQueryBuilderDsl
    {
        public ErrorByExtensionQueryBuilderDsl()
        {
        }

        public static ErrorByExtensionQueryBuilderDsl Of()
        {
            return new ErrorByExtensionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ErrorByExtensionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ErrorByExtensionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ErrorByExtensionQueryBuilderDsl>(p, ErrorByExtensionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ErrorByExtensionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ErrorByExtensionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ErrorByExtensionQueryBuilderDsl>(p, ErrorByExtensionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
