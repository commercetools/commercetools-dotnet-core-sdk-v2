using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetProductPriceCustomTypeActionQueryBuilderDsl
    {
        public ProductSetProductPriceCustomTypeActionQueryBuilderDsl()
        {
        }

        public static ProductSetProductPriceCustomTypeActionQueryBuilderDsl Of()
        {
            return new ProductSetProductPriceCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetProductPriceCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetProductPriceCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetProductPriceCustomTypeActionQueryBuilderDsl>(p, ProductSetProductPriceCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductPriceCustomTypeActionQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductSetProductPriceCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductSetProductPriceCustomTypeActionQueryBuilderDsl>(p, ProductSetProductPriceCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductPriceCustomTypeActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetProductPriceCustomTypeActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetProductPriceCustomTypeActionQueryBuilderDsl>(p, ProductSetProductPriceCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetProductPriceCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetProductPriceCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                ProductSetProductPriceCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSetProductPriceCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetProductPriceCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                ProductSetProductPriceCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
