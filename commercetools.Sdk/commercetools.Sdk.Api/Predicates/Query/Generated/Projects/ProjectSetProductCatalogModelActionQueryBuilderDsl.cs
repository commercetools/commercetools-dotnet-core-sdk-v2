// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectSetProductCatalogModelActionQueryBuilderDsl
    {
        public ProjectSetProductCatalogModelActionQueryBuilderDsl()
        {
        }

        public static ProjectSetProductCatalogModelActionQueryBuilderDsl Of()
        {
            return new ProjectSetProductCatalogModelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectSetProductCatalogModelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectSetProductCatalogModelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectSetProductCatalogModelActionQueryBuilderDsl>(p, ProjectSetProductCatalogModelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectSetProductCatalogModelActionQueryBuilderDsl, string> ProductCatalogModel()
        {
            return new ComparisonPredicateBuilder<ProjectSetProductCatalogModelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productCatalogModel")),
            p => new CombinationQueryPredicate<ProjectSetProductCatalogModelActionQueryBuilderDsl>(p, ProjectSetProductCatalogModelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
