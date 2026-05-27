// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl
    {
        public InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl Of()
        {
            return new InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl, long> NewReservationExpirationInMinutes()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newReservationExpirationInMinutes")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl, long> OldReservationExpirationInMinutes()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldReservationExpirationInMinutes")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
