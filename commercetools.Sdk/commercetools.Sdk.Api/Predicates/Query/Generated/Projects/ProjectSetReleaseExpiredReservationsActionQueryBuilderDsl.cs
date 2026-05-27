// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl
    {
        public ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl()
        {
        }

        public static ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl Of()
        {
            return new ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl>(p, ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl, bool> ReleaseExpiredReservations()
        {
            return new ComparisonPredicateBuilder<ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("releaseExpiredReservations")),
            p => new CombinationQueryPredicate<ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl>(p, ProjectSetReleaseExpiredReservationsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
