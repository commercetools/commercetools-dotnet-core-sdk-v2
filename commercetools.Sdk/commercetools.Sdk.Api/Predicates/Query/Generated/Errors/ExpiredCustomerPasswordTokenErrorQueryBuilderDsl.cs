// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExpiredCustomerPasswordTokenErrorQueryBuilderDsl
    {
        public ExpiredCustomerPasswordTokenErrorQueryBuilderDsl()
        {
        }

        public static ExpiredCustomerPasswordTokenErrorQueryBuilderDsl Of()
        {
            return new ExpiredCustomerPasswordTokenErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExpiredCustomerPasswordTokenErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExpiredCustomerPasswordTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExpiredCustomerPasswordTokenErrorQueryBuilderDsl>(p, ExpiredCustomerPasswordTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExpiredCustomerPasswordTokenErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExpiredCustomerPasswordTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExpiredCustomerPasswordTokenErrorQueryBuilderDsl>(p, ExpiredCustomerPasswordTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
