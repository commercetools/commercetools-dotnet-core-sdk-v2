using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class PriceDraftQueryBuilderDsl
    {
        public PriceDraftQueryBuilderDsl()
        {
        }

        public static PriceDraftQueryBuilderDsl Of()
        {
            return new PriceDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PriceDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<PriceDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(p, PriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PriceDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                PriceDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PriceDraftQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<PriceDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(p, PriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PriceDraftQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                PriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PriceDraftQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                PriceDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PriceDraftQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<PriceDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(p, PriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PriceDraftQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<PriceDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(p, PriceDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PriceDraftQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl.Of())),
                PriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PriceDraftQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl.Of())),
                PriceDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PriceDraftQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<PriceDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(p, PriceDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<PriceDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                PriceDraftQueryBuilderDsl.Of);
        }


    }
}
