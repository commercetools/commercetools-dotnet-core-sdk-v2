// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeRemoveEnumValuesActionQueryBuilderDsl
    {
        public ProductTypeRemoveEnumValuesActionQueryBuilderDsl()
        {
        }

        public static ProductTypeRemoveEnumValuesActionQueryBuilderDsl Of()
        {
            return new ProductTypeRemoveEnumValuesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeRemoveEnumValuesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeRemoveEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeRemoveEnumValuesActionQueryBuilderDsl>(p, ProductTypeRemoveEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeRemoveEnumValuesActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeRemoveEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeRemoveEnumValuesActionQueryBuilderDsl>(p, ProductTypeRemoveEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductTypeRemoveEnumValuesActionQueryBuilderDsl, string> Keys()
        {
            return new ComparableCollectionPredicateBuilder<ProductTypeRemoveEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("keys")),
            p => new CombinationQueryPredicate<ProductTypeRemoveEnumValuesActionQueryBuilderDsl>(p, ProductTypeRemoveEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
