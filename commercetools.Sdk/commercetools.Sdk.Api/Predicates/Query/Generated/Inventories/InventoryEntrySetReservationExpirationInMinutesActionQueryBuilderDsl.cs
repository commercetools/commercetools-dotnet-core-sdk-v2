// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl
    {
        public InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl>(p, InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl, long> ReservationExpirationInMinutes()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reservationExpirationInMinutes")),
            p => new CombinationQueryPredicate<InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl>(p, InventoryEntrySetReservationExpirationInMinutesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
