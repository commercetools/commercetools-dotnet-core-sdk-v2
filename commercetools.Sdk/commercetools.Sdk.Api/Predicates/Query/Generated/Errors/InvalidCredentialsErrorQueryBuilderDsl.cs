// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidCredentialsErrorQueryBuilderDsl
    {
        public InvalidCredentialsErrorQueryBuilderDsl()
        {
        }

        public static InvalidCredentialsErrorQueryBuilderDsl Of()
        {
            return new InvalidCredentialsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidCredentialsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidCredentialsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidCredentialsErrorQueryBuilderDsl>(p, InvalidCredentialsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidCredentialsErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidCredentialsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidCredentialsErrorQueryBuilderDsl>(p, InvalidCredentialsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
