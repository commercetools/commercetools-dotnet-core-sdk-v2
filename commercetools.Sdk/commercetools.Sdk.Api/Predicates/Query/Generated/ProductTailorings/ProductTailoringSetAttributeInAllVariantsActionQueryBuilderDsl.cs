// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl
    {
        public ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl>(p, ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl>(p, ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl>(p, ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl>(p, ProductTailoringSetAttributeInAllVariantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
