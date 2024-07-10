// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeCountriesActionQueryBuilderDsl
    {
        public ProjectChangeCountriesActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeCountriesActionQueryBuilderDsl Of()
        {
            return new ProjectChangeCountriesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeCountriesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeCountriesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeCountriesActionQueryBuilderDsl>(p, ProjectChangeCountriesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProjectChangeCountriesActionQueryBuilderDsl, string> Countries()
        {
            return new ComparableCollectionPredicateBuilder<ProjectChangeCountriesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countries")),
            p => new CombinationQueryPredicate<ProjectChangeCountriesActionQueryBuilderDsl>(p, ProjectChangeCountriesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
