using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl
    {
        public GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl> ConflictingStandalonePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingStandalonePrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl.Of())),
                GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
