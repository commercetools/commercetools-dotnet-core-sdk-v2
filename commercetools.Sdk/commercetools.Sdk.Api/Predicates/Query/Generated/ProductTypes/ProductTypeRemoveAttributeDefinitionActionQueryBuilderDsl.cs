// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl
    {
        public ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl()
        {
        }

        public static ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl Of()
        {
            return new ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl>(p, ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl>(p, ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
