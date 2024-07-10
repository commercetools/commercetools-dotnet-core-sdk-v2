using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductTailoringNameSetMessageQueryBuilderDsl
    {
        public ProductTailoringNameSetMessageQueryBuilderDsl()
        {
        }

        public static ProductTailoringNameSetMessageQueryBuilderDsl Of()
        {
            return new ProductTailoringNameSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(p, ProductTailoringNameSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(p, ProductTailoringNameSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(p, ProductTailoringNameSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(p, ProductTailoringNameSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductTailoringNameSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductTailoringNameSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(p, ProductTailoringNameSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductTailoringNameSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(p, ProductTailoringNameSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(p, ProductTailoringNameSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductTailoringNameSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                ProductTailoringNameSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, string> ProductKey()
        {
            return new ComparisonPredicateBuilder<ProductTailoringNameSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productKey")),
            p => new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(p, ProductTailoringNameSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductTailoringNameSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringNameSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl> OldName(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringNameSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldName"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringNameSetMessageQueryBuilderDsl.Of);
        }


    }
}
