// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeProductSearchStatusActionQueryBuilderDsl
    {
        public ProjectChangeProductSearchStatusActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeProductSearchStatusActionQueryBuilderDsl Of()
        {
            return new ProjectChangeProductSearchStatusActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeProductSearchStatusActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeProductSearchStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeProductSearchStatusActionQueryBuilderDsl>(p, ProjectChangeProductSearchStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeProductSearchStatusActionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ProjectChangeProductSearchStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ProjectChangeProductSearchStatusActionQueryBuilderDsl>(p, ProjectChangeProductSearchStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
