using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountValueDraftQueryBuilderDsl
    {
        public ProductDiscountValueDraftQueryBuilderDsl()
        {
        }

        public static ProductDiscountValueDraftQueryBuilderDsl Of()
        {
            return new ProductDiscountValueDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountValueDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDiscountValueDraftQueryBuilderDsl>(p, ProductDiscountValueDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductDiscountValueDraftQueryBuilderDsl> AsAbsolute(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueAbsoluteDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueAbsoluteDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountValueDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueAbsoluteDraftQueryBuilderDsl.Of()),
                ProductDiscountValueDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountValueDraftQueryBuilderDsl> AsExternal(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueExternalDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueExternalDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountValueDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueExternalDraftQueryBuilderDsl.Of()),
                ProductDiscountValueDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountValueDraftQueryBuilderDsl> AsRelative(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueRelativeDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueRelativeDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountValueDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueRelativeDraftQueryBuilderDsl.Of()),
                ProductDiscountValueDraftQueryBuilderDsl.Of);
        }
    }
}
