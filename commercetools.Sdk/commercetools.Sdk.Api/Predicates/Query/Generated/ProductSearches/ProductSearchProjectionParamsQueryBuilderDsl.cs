// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchProjectionParamsQueryBuilderDsl
    {
        public ProductSearchProjectionParamsQueryBuilderDsl()
        {
        }

        public static ProductSearchProjectionParamsQueryBuilderDsl Of()
        {
            return new ProductSearchProjectionParamsQueryBuilderDsl();
        }

        public IComparableCollectionPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string> Expand()
        {
            return new ComparableCollectionPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expand")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string> PriceCurrency()
        {
            return new ComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceCurrency")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string> PriceCountry()
        {
            return new ComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceCountry")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string> PriceCustomerGroup()
        {
            return new ComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceCustomerGroup")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string> PriceCustomerGroupAssignments()
        {
            return new ComparableCollectionPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceCustomerGroupAssignments")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string> PriceChannel()
        {
            return new ComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceChannel")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string> LocaleProjection()
        {
            return new ComparableCollectionPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("localeProjection")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string> StoreProjection()
        {
            return new ComparisonPredicateBuilder<ProductSearchProjectionParamsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeProjection")),
            p => new CombinationQueryPredicate<ProductSearchProjectionParamsQueryBuilderDsl>(p, ProductSearchProjectionParamsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
