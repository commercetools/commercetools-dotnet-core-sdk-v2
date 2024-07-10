using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitStoreModeChangedMessageQueryBuilderDsl
    {
        public BusinessUnitStoreModeChangedMessageQueryBuilderDsl()
        {
        }

        public static BusinessUnitStoreModeChangedMessageQueryBuilderDsl Of()
        {
            return new BusinessUnitStoreModeChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, string> StoreMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeMode")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl> OldStores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldStores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl> OldStores()
        {
            return new CollectionPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStores")),
                    p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, string> OldStoreMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStoreModeChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStoreMode")),
            p => new CombinationQueryPredicate<BusinessUnitStoreModeChangedMessageQueryBuilderDsl>(p, BusinessUnitStoreModeChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
