using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl
    {
        public ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl()
        {
        }

        public static ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl Of()
        {
            return new ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(p, ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(p, ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(p, ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(p, ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(p, ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(p, ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(p, ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl> OldVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldVariantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl> NewVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newVariantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessageQueryBuilderDsl.Of);
        }


    }
}
