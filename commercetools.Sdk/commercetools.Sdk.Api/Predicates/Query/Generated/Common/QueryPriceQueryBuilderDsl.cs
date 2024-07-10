using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class QueryPriceQueryBuilderDsl
    {
        public QueryPriceQueryBuilderDsl()
        {
        }

        public static QueryPriceQueryBuilderDsl Of()
        {
            return new QueryPriceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QueryPriceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QueryPriceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(p, QueryPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QueryPriceQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                QueryPriceQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QueryPriceQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<QueryPriceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(p, QueryPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QueryPriceQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                QueryPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QueryPriceQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                QueryPriceQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QueryPriceQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<QueryPriceQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(p, QueryPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QueryPriceQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<QueryPriceQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(p, QueryPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QueryPriceQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl.Of())),
                QueryPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QueryPriceQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                QueryPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QueryPriceQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl.Of())),
                QueryPriceQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QueryPriceQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<QueryPriceQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<QueryPriceQueryBuilderDsl>(p, QueryPriceQueryBuilderDsl.Of));
        }

    }
}
