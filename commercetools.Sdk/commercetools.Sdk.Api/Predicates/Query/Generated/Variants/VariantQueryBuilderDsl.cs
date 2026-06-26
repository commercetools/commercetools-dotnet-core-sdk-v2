using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantQueryBuilderDsl
    {
        public VariantQueryBuilderDsl()
        {
        }

        public static VariantQueryBuilderDsl Of()
        {
            return new VariantQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantQueryBuilderDsl>(p, VariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<VariantQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<VariantQueryBuilderDsl>(p, VariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<VariantQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<VariantQueryBuilderDsl>(p, VariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<VariantQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<VariantQueryBuilderDsl>(p, VariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                VariantQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                VariantQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantQueryBuilderDsl>(p, VariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<VariantQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<VariantQueryBuilderDsl>(p, VariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                VariantQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantQueryBuilderDsl, bool> Published()
        {
            return new ComparisonPredicateBuilder<VariantQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("published")),
            p => new CombinationQueryPredicate<VariantQueryBuilderDsl>(p, VariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantQueryBuilderDsl> Current(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("current"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantDataQueryBuilderDsl.Of())),
                VariantQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantQueryBuilderDsl> Staged(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("staged"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantDataQueryBuilderDsl.Of())),
                VariantQueryBuilderDsl.Of);
        }


    }
}
