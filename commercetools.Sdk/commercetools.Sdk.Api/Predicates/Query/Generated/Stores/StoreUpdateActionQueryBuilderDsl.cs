using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreUpdateActionQueryBuilderDsl
    {
        public StoreUpdateActionQueryBuilderDsl()
        {
        }

        public static StoreUpdateActionQueryBuilderDsl Of()
        {
            return new StoreUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(p, StoreUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsAddCountry(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddCountryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddCountryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddCountryActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsAddDistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddDistributionChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddDistributionChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddDistributionChannelActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsAddProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddProductSelectionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddProductSelectionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddProductSelectionActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsAddSupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddSupplyChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddSupplyChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreAddSupplyChannelActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsChangeProductSelectionActive(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreChangeProductSelectionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreChangeProductSelectionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreChangeProductSelectionActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsRemoveCountry(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveCountryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveCountryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveCountryActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsRemoveDistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveDistributionChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveDistributionChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveDistributionChannelActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsRemoveProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveProductSelectionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveProductSelectionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveProductSelectionActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsRemoveSupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveSupplyChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveSupplyChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreRemoveSupplyChannelActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsSetCountries(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCountriesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCountriesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCountriesActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCustomFieldActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetCustomTypeActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsSetDistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetDistributionChannelsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetDistributionChannelsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetDistributionChannelsActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsSetLanguages(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetLanguagesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetLanguagesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetLanguagesActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetNameActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsSetProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetProductSelectionsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetProductSelectionsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetProductSelectionsActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl> AsSetSupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetSupplyChannelsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetSupplyChannelsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreSetSupplyChannelsActionQueryBuilderDsl.Of()),
                StoreUpdateActionQueryBuilderDsl.Of);
        }
    }
}
