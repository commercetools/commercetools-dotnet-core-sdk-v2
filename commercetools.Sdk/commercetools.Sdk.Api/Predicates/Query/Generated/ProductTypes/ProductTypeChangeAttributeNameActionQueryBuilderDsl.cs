// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeAttributeNameActionQueryBuilderDsl
    {
        public ProductTypeChangeAttributeNameActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeAttributeNameActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeAttributeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeAttributeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeAttributeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeAttributeNameActionQueryBuilderDsl>(p, ProductTypeChangeAttributeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeAttributeNameActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeAttributeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeAttributeNameActionQueryBuilderDsl>(p, ProductTypeChangeAttributeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeAttributeNameActionQueryBuilderDsl, string> NewAttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeAttributeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newAttributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeAttributeNameActionQueryBuilderDsl>(p, ProductTypeChangeAttributeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
