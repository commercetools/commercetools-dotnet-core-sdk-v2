using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountDraftQueryBuilderDsl
    {
        public ProductDiscountDraftQueryBuilderDsl()
        {
        }

        public static ProductDiscountDraftQueryBuilderDsl Of()
        {
            return new ProductDiscountDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDiscountDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(p, ProductDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDiscountDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueDraftQueryBuilderDsl.Of())),
                ProductDiscountDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(p, ProductDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(p, ProductDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(p, ProductDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(p, ProductDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<ProductDiscountDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<ProductDiscountDraftQueryBuilderDsl>(p, ProductDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
