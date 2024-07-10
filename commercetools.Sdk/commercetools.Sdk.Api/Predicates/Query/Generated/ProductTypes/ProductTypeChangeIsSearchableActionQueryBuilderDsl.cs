// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeIsSearchableActionQueryBuilderDsl
    {
        public ProductTypeChangeIsSearchableActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeIsSearchableActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeIsSearchableActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeIsSearchableActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeIsSearchableActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeIsSearchableActionQueryBuilderDsl>(p, ProductTypeChangeIsSearchableActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeIsSearchableActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeIsSearchableActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeIsSearchableActionQueryBuilderDsl>(p, ProductTypeChangeIsSearchableActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeIsSearchableActionQueryBuilderDsl, bool> IsSearchable()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeIsSearchableActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isSearchable")),
            p => new CombinationQueryPredicate<ProductTypeChangeIsSearchableActionQueryBuilderDsl>(p, ProductTypeChangeIsSearchableActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
