// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetCustomerEmailActionQueryBuilderDsl
    {
        public CartSetCustomerEmailActionQueryBuilderDsl()
        {
        }

        public static CartSetCustomerEmailActionQueryBuilderDsl Of()
        {
            return new CartSetCustomerEmailActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetCustomerEmailActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetCustomerEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetCustomerEmailActionQueryBuilderDsl>(p, CartSetCustomerEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetCustomerEmailActionQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<CartSetCustomerEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<CartSetCustomerEmailActionQueryBuilderDsl>(p, CartSetCustomerEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
