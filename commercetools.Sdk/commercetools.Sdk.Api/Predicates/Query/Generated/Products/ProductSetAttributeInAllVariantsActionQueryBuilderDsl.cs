// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetAttributeInAllVariantsActionQueryBuilderDsl
    {
        public ProductSetAttributeInAllVariantsActionQueryBuilderDsl()
        {
        }

        public static ProductSetAttributeInAllVariantsActionQueryBuilderDsl Of()
        {
            return new ProductSetAttributeInAllVariantsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetAttributeInAllVariantsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeInAllVariantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetAttributeInAllVariantsActionQueryBuilderDsl>(p, ProductSetAttributeInAllVariantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAttributeInAllVariantsActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeInAllVariantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSetAttributeInAllVariantsActionQueryBuilderDsl>(p, ProductSetAttributeInAllVariantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAttributeInAllVariantsActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeInAllVariantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductSetAttributeInAllVariantsActionQueryBuilderDsl>(p, ProductSetAttributeInAllVariantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAttributeInAllVariantsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeInAllVariantsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetAttributeInAllVariantsActionQueryBuilderDsl>(p, ProductSetAttributeInAllVariantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
