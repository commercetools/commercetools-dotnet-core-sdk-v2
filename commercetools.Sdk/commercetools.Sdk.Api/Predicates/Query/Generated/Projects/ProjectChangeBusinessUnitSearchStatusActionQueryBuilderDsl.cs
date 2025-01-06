// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl
    {
        public ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl Of()
        {
            return new ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl>(p, ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl>(p, ProjectChangeBusinessUnitSearchStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
