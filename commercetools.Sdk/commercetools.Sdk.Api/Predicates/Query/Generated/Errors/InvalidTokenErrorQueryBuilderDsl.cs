// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidTokenErrorQueryBuilderDsl
    {
        public InvalidTokenErrorQueryBuilderDsl()
        {
        }

        public static InvalidTokenErrorQueryBuilderDsl Of()
        {
            return new InvalidTokenErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidTokenErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidTokenErrorQueryBuilderDsl>(p, InvalidTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidTokenErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidTokenErrorQueryBuilderDsl>(p, InvalidTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
