using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantUnpublishedMessageQueryBuilderDsl
    {
        public VariantUnpublishedMessageQueryBuilderDsl()
        {
        }

        public static VariantUnpublishedMessageQueryBuilderDsl Of()
        {
            return new VariantUnpublishedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(p, VariantUnpublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(p, VariantUnpublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(p, VariantUnpublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(p, VariantUnpublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                VariantUnpublishedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                VariantUnpublishedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(p, VariantUnpublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                VariantUnpublishedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(p, VariantUnpublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(p, VariantUnpublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                VariantUnpublishedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUnpublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                VariantUnpublishedMessageQueryBuilderDsl.Of);
        }


    }
}
