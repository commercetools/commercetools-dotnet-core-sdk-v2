// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl
    {
        public ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl()
        {
        }

        public static ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl Of()
        {
            return new ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl>(p, ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl, long> ReservationExpirationInMinutes()
        {
            return new ComparisonPredicateBuilder<ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reservationExpirationInMinutes")),
            p => new CombinationQueryPredicate<ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl>(p, ProjectSetReservationExpirationInMinutesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
