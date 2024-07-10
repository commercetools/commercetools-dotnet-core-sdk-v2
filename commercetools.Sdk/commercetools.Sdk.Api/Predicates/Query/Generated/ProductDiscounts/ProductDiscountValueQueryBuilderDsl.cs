using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountValueQueryBuilderDsl
    {
        public ProductDiscountValueQueryBuilderDsl()
        {
        }

        public static ProductDiscountValueQueryBuilderDsl Of()
        {
            return new ProductDiscountValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountValueQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDiscountValueQueryBuilderDsl>(p, ProductDiscountValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductDiscountValueQueryBuilderDsl> AsAbsolute(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueAbsoluteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueAbsoluteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueAbsoluteQueryBuilderDsl.Of()),
                ProductDiscountValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountValueQueryBuilderDsl> AsExternal(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueExternalQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueExternalQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueExternalQueryBuilderDsl.Of()),
                ProductDiscountValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountValueQueryBuilderDsl> AsRelative(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueRelativeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueRelativeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueRelativeQueryBuilderDsl.Of()),
                ProductDiscountValueQueryBuilderDsl.Of);
        }
    }
}
