using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductRevertedStagedChangesMessageQueryBuilderDsl
    {
        public ProductRevertedStagedChangesMessageQueryBuilderDsl()
        {
        }

        public static ProductRevertedStagedChangesMessageQueryBuilderDsl Of()
        {
            return new ProductRevertedStagedChangesMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(p, ProductRevertedStagedChangesMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(p, ProductRevertedStagedChangesMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(p, ProductRevertedStagedChangesMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(p, ProductRevertedStagedChangesMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductRevertedStagedChangesMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductRevertedStagedChangesMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(p, ProductRevertedStagedChangesMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductRevertedStagedChangesMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(p, ProductRevertedStagedChangesMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(p, ProductRevertedStagedChangesMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductRevertedStagedChangesMessageQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, string> RemovedImageUrls()
        {
            return new ComparableCollectionPredicateBuilder<ProductRevertedStagedChangesMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedImageUrls")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessageQueryBuilderDsl>(p, ProductRevertedStagedChangesMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
