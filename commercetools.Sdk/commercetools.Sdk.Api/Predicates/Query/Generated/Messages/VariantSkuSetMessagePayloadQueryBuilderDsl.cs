using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantSkuSetMessagePayloadQueryBuilderDsl
    {
        public VariantSkuSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantSkuSetMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantSkuSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSkuSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantSkuSetMessagePayloadQueryBuilderDsl>(p, VariantSkuSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSkuSetMessagePayloadQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSkuSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                VariantSkuSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantSkuSetMessagePayloadQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantSkuSetMessagePayloadQueryBuilderDsl>(p, VariantSkuSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSkuSetMessagePayloadQueryBuilderDsl, string> OldSku()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldSku")),
            p => new CombinationQueryPredicate<VariantSkuSetMessagePayloadQueryBuilderDsl>(p, VariantSkuSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSkuSetMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSkuSetMessagePayloadQueryBuilderDsl>(p, VariantSkuSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
