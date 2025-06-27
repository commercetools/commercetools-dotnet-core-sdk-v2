// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeTaxRoundingModeActionQueryBuilderDsl
    {
        public ProjectChangeTaxRoundingModeActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeTaxRoundingModeActionQueryBuilderDsl Of()
        {
            return new ProjectChangeTaxRoundingModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeTaxRoundingModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeTaxRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeTaxRoundingModeActionQueryBuilderDsl>(p, ProjectChangeTaxRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeTaxRoundingModeActionQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<ProjectChangeTaxRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<ProjectChangeTaxRoundingModeActionQueryBuilderDsl>(p, ProjectChangeTaxRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
