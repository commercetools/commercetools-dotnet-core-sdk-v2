// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductSelectionDeletedMessagePayloadQueryBuilderDsl
    {
        public ProductSelectionDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductSelectionDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductSelectionDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductSelectionDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductSelectionDeletedMessagePayloadQueryBuilderDsl>(p, ProductSelectionDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
