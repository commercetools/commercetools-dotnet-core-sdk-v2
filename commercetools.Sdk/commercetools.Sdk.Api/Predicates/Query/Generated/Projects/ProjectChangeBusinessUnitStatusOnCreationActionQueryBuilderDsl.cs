// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl
    {
        public ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl Of()
        {
            return new ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl>(p, ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl>(p, ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
