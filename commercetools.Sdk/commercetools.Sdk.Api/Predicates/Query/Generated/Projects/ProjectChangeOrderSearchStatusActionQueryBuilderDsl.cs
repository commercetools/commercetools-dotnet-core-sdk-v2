// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeOrderSearchStatusActionQueryBuilderDsl
    {
        public ProjectChangeOrderSearchStatusActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeOrderSearchStatusActionQueryBuilderDsl Of()
        {
            return new ProjectChangeOrderSearchStatusActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeOrderSearchStatusActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeOrderSearchStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeOrderSearchStatusActionQueryBuilderDsl>(p, ProjectChangeOrderSearchStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeOrderSearchStatusActionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ProjectChangeOrderSearchStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ProjectChangeOrderSearchStatusActionQueryBuilderDsl>(p, ProjectChangeOrderSearchStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
