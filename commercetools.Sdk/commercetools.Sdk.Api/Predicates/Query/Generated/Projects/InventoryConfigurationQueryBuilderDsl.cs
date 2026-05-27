// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class InventoryConfigurationQueryBuilderDsl
    {
        public InventoryConfigurationQueryBuilderDsl()
        {
        }

        public static InventoryConfigurationQueryBuilderDsl Of()
        {
            return new InventoryConfigurationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryConfigurationQueryBuilderDsl, long> ReservationExpirationInMinutes()
        {
            return new ComparisonPredicateBuilder<InventoryConfigurationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reservationExpirationInMinutes")),
            p => new CombinationQueryPredicate<InventoryConfigurationQueryBuilderDsl>(p, InventoryConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryConfigurationQueryBuilderDsl, bool> ReleaseExpiredReservations()
        {
            return new ComparisonPredicateBuilder<InventoryConfigurationQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("releaseExpiredReservations")),
            p => new CombinationQueryPredicate<InventoryConfigurationQueryBuilderDsl>(p, InventoryConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
