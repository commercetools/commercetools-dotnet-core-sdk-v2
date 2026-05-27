// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetReservationExpirationInMinutesActionQueryBuilderDsl
    {
        public CartSetReservationExpirationInMinutesActionQueryBuilderDsl()
        {
        }

        public static CartSetReservationExpirationInMinutesActionQueryBuilderDsl Of()
        {
            return new CartSetReservationExpirationInMinutesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetReservationExpirationInMinutesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetReservationExpirationInMinutesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetReservationExpirationInMinutesActionQueryBuilderDsl>(p, CartSetReservationExpirationInMinutesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetReservationExpirationInMinutesActionQueryBuilderDsl, long> ReservationExpirationInMinutes()
        {
            return new ComparisonPredicateBuilder<CartSetReservationExpirationInMinutesActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reservationExpirationInMinutes")),
            p => new CombinationQueryPredicate<CartSetReservationExpirationInMinutesActionQueryBuilderDsl>(p, CartSetReservationExpirationInMinutesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
