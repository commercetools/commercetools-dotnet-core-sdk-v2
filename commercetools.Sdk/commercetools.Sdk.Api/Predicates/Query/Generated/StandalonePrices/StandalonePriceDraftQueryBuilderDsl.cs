using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceDraftQueryBuilderDsl
    {
        public StandalonePriceDraftQueryBuilderDsl()
        {
        }

        public static StandalonePriceDraftQueryBuilderDsl Of()
        {
            return new StandalonePriceDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(p, StandalonePriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(p, StandalonePriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                StandalonePriceDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(p, StandalonePriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                StandalonePriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StandalonePriceDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(p, StandalonePriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(p, StandalonePriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl.Of())),
                StandalonePriceDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StandalonePriceDraftQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<StandalonePriceDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(p, StandalonePriceDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl.Of())),
                StandalonePriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                StandalonePriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl> Staged(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedPriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedPriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("staged"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedPriceDraftQueryBuilderDsl.Of())),
                StandalonePriceDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<StandalonePriceDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<StandalonePriceDraftQueryBuilderDsl>(p, StandalonePriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
