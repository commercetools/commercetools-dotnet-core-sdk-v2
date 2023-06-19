using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class VariantValuesQueryBuilderDsl
    {
        public VariantValuesQueryBuilderDsl()
        {
        }

        public static VariantValuesQueryBuilderDsl Of()
        {
            return new VariantValuesQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantValuesQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantValuesQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantValuesQueryBuilderDsl>(p, VariantValuesQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantValuesQueryBuilderDsl> Prices(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantValuesQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prices"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                VariantValuesQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantValuesQueryBuilderDsl> Prices()
        {
            return new CollectionPredicateBuilder<VariantValuesQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prices")),
                    p => new CombinationQueryPredicate<VariantValuesQueryBuilderDsl>(p, VariantValuesQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantValuesQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantValuesQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                VariantValuesQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantValuesQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<VariantValuesQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<VariantValuesQueryBuilderDsl>(p, VariantValuesQueryBuilderDsl.Of));
        }

    }
}
