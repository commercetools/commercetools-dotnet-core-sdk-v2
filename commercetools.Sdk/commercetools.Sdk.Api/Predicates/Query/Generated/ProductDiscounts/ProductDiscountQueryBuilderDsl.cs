using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountQueryBuilderDsl
    {
        public ProductDiscountQueryBuilderDsl()
        {
        }

        public static ProductDiscountQueryBuilderDsl Of()
        {
            return new ProductDiscountQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductDiscountQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDiscountQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductDiscountQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDiscountQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDiscountQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDiscountQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDiscountQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueQueryBuilderDsl.Of())),
                ProductDiscountQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountQueryBuilderDsl> References(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("references"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductDiscountQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDiscountQueryBuilderDsl> References()
        {
            return new CollectionPredicateBuilder<ProductDiscountQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("references")),
                    p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<ProductDiscountQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<ProductDiscountQueryBuilderDsl>(p, ProductDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
