// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeNameActionQueryBuilderDsl
    {
        public ProjectChangeNameActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeNameActionQueryBuilderDsl Of()
        {
            return new ProjectChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeNameActionQueryBuilderDsl>(p, ProjectChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProjectChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProjectChangeNameActionQueryBuilderDsl>(p, ProjectChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
