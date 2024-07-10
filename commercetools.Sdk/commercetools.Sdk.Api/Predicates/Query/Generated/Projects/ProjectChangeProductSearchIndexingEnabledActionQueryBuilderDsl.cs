// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl
    {
        public ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl Of()
        {
            return new ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl>(p, ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl, bool> Enabled()
        {
            return new ComparisonPredicateBuilder<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("enabled")),
            p => new CombinationQueryPredicate<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl>(p, ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl, string> Mode()
        {
            return new ComparisonPredicateBuilder<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mode")),
            p => new CombinationQueryPredicate<ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl>(p, ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
