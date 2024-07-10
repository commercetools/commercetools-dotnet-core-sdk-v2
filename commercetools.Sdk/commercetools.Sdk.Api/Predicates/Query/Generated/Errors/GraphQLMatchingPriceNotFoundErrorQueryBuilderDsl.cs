using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl
    {
        public GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl Of()
        {
            return new GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl>(p, GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl>(p, GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl>(p, GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl>(p, GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl>(p, GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl.Of);
        }


    }
}
