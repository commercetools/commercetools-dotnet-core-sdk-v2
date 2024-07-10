using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreProductSelectionsChangedMessageQueryBuilderDsl
    {
        public StoreProductSelectionsChangedMessageQueryBuilderDsl()
        {
        }

        public static StoreProductSelectionsChangedMessageQueryBuilderDsl Of()
        {
            return new StoreProductSelectionsChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl> AddedProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addedProductSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl> AddedProductSelections()
        {
            return new CollectionPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedProductSelections")),
                    p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl> RemovedProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedProductSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl> RemovedProductSelections()
        {
            return new CollectionPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedProductSelections")),
                    p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl> UpdatedProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("updatedProductSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl> UpdatedProductSelections()
        {
            return new CollectionPredicateBuilder<StoreProductSelectionsChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updatedProductSelections")),
                    p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessageQueryBuilderDsl>(p, StoreProductSelectionsChangedMessageQueryBuilderDsl.Of));
        }

    }
}
