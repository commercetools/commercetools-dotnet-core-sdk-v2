using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantImagesSetMessageQueryBuilderDsl
    {
        public VariantImagesSetMessageQueryBuilderDsl()
        {
        }

        public static VariantImagesSetMessageQueryBuilderDsl Of()
        {
            return new VariantImagesSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                VariantImagesSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                VariantImagesSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                VariantImagesSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                VariantImagesSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantImagesSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl> OldImages(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldImages"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantImagesSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl> OldImages()
        {
            return new CollectionPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldImages")),
                    p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantImagesSetMessageQueryBuilderDsl>(p, VariantImagesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
