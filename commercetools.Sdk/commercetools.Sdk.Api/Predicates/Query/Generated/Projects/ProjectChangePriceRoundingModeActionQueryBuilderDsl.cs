// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangePriceRoundingModeActionQueryBuilderDsl
    {
        public ProjectChangePriceRoundingModeActionQueryBuilderDsl()
        {
        }

        public static ProjectChangePriceRoundingModeActionQueryBuilderDsl Of()
        {
            return new ProjectChangePriceRoundingModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangePriceRoundingModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangePriceRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangePriceRoundingModeActionQueryBuilderDsl>(p, ProjectChangePriceRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangePriceRoundingModeActionQueryBuilderDsl, string> PriceRoundingMode()
        {
            return new ComparisonPredicateBuilder<ProjectChangePriceRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceRoundingMode")),
            p => new CombinationQueryPredicate<ProjectChangePriceRoundingModeActionQueryBuilderDsl>(p, ProjectChangePriceRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
