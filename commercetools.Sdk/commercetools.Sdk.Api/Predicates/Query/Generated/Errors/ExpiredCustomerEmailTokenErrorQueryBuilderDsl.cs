// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExpiredCustomerEmailTokenErrorQueryBuilderDsl
    {
        public ExpiredCustomerEmailTokenErrorQueryBuilderDsl()
        {
        }

        public static ExpiredCustomerEmailTokenErrorQueryBuilderDsl Of()
        {
            return new ExpiredCustomerEmailTokenErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExpiredCustomerEmailTokenErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExpiredCustomerEmailTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExpiredCustomerEmailTokenErrorQueryBuilderDsl>(p, ExpiredCustomerEmailTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExpiredCustomerEmailTokenErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExpiredCustomerEmailTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExpiredCustomerEmailTokenErrorQueryBuilderDsl>(p, ExpiredCustomerEmailTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
