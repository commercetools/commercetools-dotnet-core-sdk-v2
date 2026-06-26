using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantSkuSetMessageQueryBuilderDsl
    {
        public VariantSkuSetMessageQueryBuilderDsl()
        {
        }

        public static VariantSkuSetMessageQueryBuilderDsl Of()
        {
            return new VariantSkuSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                VariantSkuSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                VariantSkuSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                VariantSkuSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                VariantSkuSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, string> OldSku()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldSku")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSkuSetMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSkuSetMessageQueryBuilderDsl>(p, VariantSkuSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
