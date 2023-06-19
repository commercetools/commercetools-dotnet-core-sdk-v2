using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodUpdateActionQueryBuilderDsl
    {
        public ShippingMethodUpdateActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodUpdateActionQueryBuilderDsl Of()
        {
            return new ShippingMethodUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(p, ShippingMethodUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsAddShippingRate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodAddShippingRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodAddShippingRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodAddShippingRateActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsAddZone(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodAddZoneActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodAddZoneActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodAddZoneActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsChangeIsDefault(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeIsDefaultActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeIsDefaultActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeIsDefaultActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeNameActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsChangeTaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeTaxCategoryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeTaxCategoryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodChangeTaxCategoryActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsRemoveShippingRate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodRemoveShippingRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodRemoveShippingRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodRemoveShippingRateActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsRemoveZone(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodRemoveZoneActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodRemoveZoneActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodRemoveZoneActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetCustomFieldActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetCustomTypeActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }

        [Obsolete]
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetDescriptionActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetKeyActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsSetLocalizedDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsSetLocalizedName(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetLocalizedNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetLocalizedNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetLocalizedNameActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl> AsSetPredicate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetPredicateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetPredicateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodSetPredicateActionQueryBuilderDsl.Of()),
                ShippingMethodUpdateActionQueryBuilderDsl.Of);
        }
    }
}
