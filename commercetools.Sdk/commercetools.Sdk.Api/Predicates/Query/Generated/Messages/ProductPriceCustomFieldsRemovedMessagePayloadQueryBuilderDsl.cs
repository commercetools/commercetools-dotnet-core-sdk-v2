// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl
    {
        public ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldsRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
