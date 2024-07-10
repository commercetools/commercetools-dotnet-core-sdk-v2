using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MatchingPriceNotFoundErrorQueryBuilderDsl
    {
        public MatchingPriceNotFoundErrorQueryBuilderDsl()
        {
        }

        public static MatchingPriceNotFoundErrorQueryBuilderDsl Of()
        {
            return new MatchingPriceNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl>(p, MatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl>(p, MatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl>(p, MatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl>(p, MatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl>(p, MatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<MatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl>(p, MatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                MatchingPriceNotFoundErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MatchingPriceNotFoundErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                MatchingPriceNotFoundErrorQueryBuilderDsl.Of);
        }


    }
}
