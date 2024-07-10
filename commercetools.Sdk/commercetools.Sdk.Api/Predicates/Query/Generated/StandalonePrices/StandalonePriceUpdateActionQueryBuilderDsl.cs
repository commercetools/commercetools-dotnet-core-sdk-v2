using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceUpdateActionQueryBuilderDsl
    {
        public StandalonePriceUpdateActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceUpdateActionQueryBuilderDsl Of()
        {
            return new StandalonePriceUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(p, StandalonePriceUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsAddPriceTier(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceAddPriceTierActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceAddPriceTierActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceAddPriceTierActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsApplyStagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceApplyStagedChangesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceApplyStagedChangesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceApplyStagedChangesActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsChangeActive(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceChangeActiveActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceChangeActiveActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceChangeActiveActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsChangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceChangeValueActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceChangeValueActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceChangeValueActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsRemovePriceTier(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceRemovePriceTierActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceRemovePriceTierActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceRemovePriceTierActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsRemoveStagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceRemoveStagedChangesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceRemoveStagedChangesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceRemoveStagedChangesActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetCustomFieldActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetCustomTypeActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsSetDiscountedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetDiscountedPriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetDiscountedPriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetDiscountedPriceActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetKeyActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsSetPriceTiers(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetPriceTiersActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetPriceTiersActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetPriceTiersActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsSetValidFrom(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidFromActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidFromActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidFromActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsSetValidFromAndUntil(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl> AsSetValidUntil(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidUntilActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidUntilActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceSetValidUntilActionQueryBuilderDsl.Of()),
                StandalonePriceUpdateActionQueryBuilderDsl.Of);
        }
    }
}
