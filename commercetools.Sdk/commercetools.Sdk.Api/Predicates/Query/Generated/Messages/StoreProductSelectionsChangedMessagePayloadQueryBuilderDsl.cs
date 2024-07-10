using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl
    {
        public StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(p, StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl> AddedProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addedProductSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl> AddedProductSelections()
        {
            return new CollectionPredicateBuilder<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedProductSelections")),
                    p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(p, StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl> RemovedProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedProductSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl> RemovedProductSelections()
        {
            return new CollectionPredicateBuilder<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedProductSelections")),
                    p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(p, StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl> UpdatedProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("updatedProductSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl> UpdatedProductSelections()
        {
            return new CollectionPredicateBuilder<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updatedProductSelections")),
                    p => new CombinationQueryPredicate<StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl>(p, StoreProductSelectionsChangedMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
