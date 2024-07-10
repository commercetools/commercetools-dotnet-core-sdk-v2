// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ContentTooLargeErrorQueryBuilderDsl
    {
        public ContentTooLargeErrorQueryBuilderDsl()
        {
        }

        public static ContentTooLargeErrorQueryBuilderDsl Of()
        {
            return new ContentTooLargeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ContentTooLargeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ContentTooLargeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ContentTooLargeErrorQueryBuilderDsl>(p, ContentTooLargeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ContentTooLargeErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ContentTooLargeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ContentTooLargeErrorQueryBuilderDsl>(p, ContentTooLargeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
