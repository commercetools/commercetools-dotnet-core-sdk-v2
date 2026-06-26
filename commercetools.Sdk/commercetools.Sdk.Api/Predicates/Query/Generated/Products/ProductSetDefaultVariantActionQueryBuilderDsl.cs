using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetDefaultVariantActionQueryBuilderDsl
    {
        public ProductSetDefaultVariantActionQueryBuilderDsl()
        {
        }

        public static ProductSetDefaultVariantActionQueryBuilderDsl Of()
        {
            return new ProductSetDefaultVariantActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetDefaultVariantActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetDefaultVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetDefaultVariantActionQueryBuilderDsl>(p, ProductSetDefaultVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetDefaultVariantActionQueryBuilderDsl> Variant(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetDefaultVariantActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantResourceIdentifierQueryBuilderDsl.Of())),
                ProductSetDefaultVariantActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSetDefaultVariantActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetDefaultVariantActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetDefaultVariantActionQueryBuilderDsl>(p, ProductSetDefaultVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
