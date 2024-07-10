using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetProductSelectionsActionQueryBuilderDsl
    {
        public StoreSetProductSelectionsActionQueryBuilderDsl()
        {
        }

        public static StoreSetProductSelectionsActionQueryBuilderDsl Of()
        {
            return new StoreSetProductSelectionsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetProductSelectionsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetProductSelectionsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetProductSelectionsActionQueryBuilderDsl>(p, StoreSetProductSelectionsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSetProductSelectionsActionQueryBuilderDsl> ProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSetProductSelectionsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingDraftQueryBuilderDsl.Of())),
                StoreSetProductSelectionsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreSetProductSelectionsActionQueryBuilderDsl> ProductSelections()
        {
            return new CollectionPredicateBuilder<StoreSetProductSelectionsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productSelections")),
                    p => new CombinationQueryPredicate<StoreSetProductSelectionsActionQueryBuilderDsl>(p, StoreSetProductSelectionsActionQueryBuilderDsl.Of));
        }

    }
}
